using System.Diagnostics;
using System.Net.NetworkInformation;

namespace DnsChanger.WinForms;

public partial class MainForm : Form
{
    private readonly ApplicationDbContext _context;

    public MainForm()
    {
        InitializeComponent();
        _context = Program.GetService<ApplicationDbContext>() ??
                   throw new NullReferenceException();
    }

    public void RefreshList()
    {
        dgvDnsList.DataSource = _context.Dns
            .OrderByDescending(d => d.Id)
            .ToList();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        dgvDnsList.AutoGenerateColumns = false;
        RefreshList();
        RefreshCurrentDnsBox();
    }

    public void RefreshCurrentDnsBox()
    {
        var tasks = new[]
        {
            Task.Run(GetCurrentDns)
        };
        Task.WaitAll(tasks);
    }

    public async Task GetCurrentDns()
    {
        lblCurrentPreferred.Text = @"DHCP";
        lblCurrentAlternate.Text = @"DHCP";
        var nic = await GetActiveEthernetOrWifiNetworkInterface();
        if (nic == null) return;
        var dnsAddresses = nic.GetIPProperties().DnsAddresses;
        if (dnsAddresses.Count >= 2)
        {
            lblCurrentPreferred.Text = dnsAddresses[0].ToString();
            lblCurrentAlternate.Text = dnsAddresses[1].ToString();
        }
    }

    private void Clear()
    {
        txtDescription.Text = string.Empty;
        txtPre1.Text = string.Empty;
        txtPre2.Text = string.Empty;
        txtPre3.Text = string.Empty;
        txtPre4.Text = string.Empty;
        txtAlter1.Text = string.Empty;
        txtAlter2.Text = string.Empty;
        txtAlter3.Text = string.Empty;
        txtAlter4.Text = string.Empty;
    }

    public Task<NetworkInterface?> GetActiveEthernetOrWifiNetworkInterface()
        => Task.FromResult(NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(
            a => a.OperationalStatus == OperationalStatus.Up &&
                 (a.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || a.NetworkInterfaceType == NetworkInterfaceType.Ethernet) &&
                 a.GetIPProperties().GatewayAddresses.Any(g => g.Address.AddressFamily.ToString() == "InterNetwork")));

    private bool RunCommand(string arg)
    {
        try
        {
            ProcessStartInfo psi = new ProcessStartInfo("powershell.exe");
            psi.UseShellExecute = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.Verb = "runas";
            psi.Arguments = arg;
            Process.Start(psi);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public string CreateSetCommand(string nicName, string preferred, string alternate)
        => $"netsh interface ipv4 add dnsservers \"{nicName}\" address={preferred} index=1 ; netsh interface ipv4 add dnsservers \"{nicName}\" address={alternate} index=2";


    private void btnSet_Click(object sender, EventArgs e)
    {
        var nic = GetActiveEthernetOrWifiNetworkInterface().Result;
        if (nic == null)
        {
            MessageBox.Show(@"There is a problem in get network interface information!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        //var preferred = $"{txtPre1.Text}.{txtPre2.Text}.{txtPre3.Text}.{txtPre4.Text}";
        //var alternate = $"{txtAlter1.Text}.{txtAlter2.Text}.{txtAlter3.Text}.{txtAlter4.Text}";

        if (!_context.Dns.Any(d => d.Preferred == txtPre1.Text &&
                                   d.Alternate == txtAlter1.Text))
        {
            _context.Dns.Add(new Dns()
            {
                Description = txtDescription.Text,
                Preferred = txtPre1.Text,
                Alternate = txtAlter1.Text
            });
            var saveRes = _context.SaveChanges();
            if (saveRes > 0) RefreshList();
        }

        btnUnSet_Click(null, null);


        var commandRes = RunCommand(CreateSetCommand(nic.Name, txtPre1.Text, txtAlter1.Text));
        if (commandRes)
        {
            Clear();

            MessageBox.Show(@"Dns addresses have been changed", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        MessageBox.Show(@"There is a problem in change dns addresses!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
        btnUnSet_Click(null, null);

    }

    private void btnUnSet_Click(object sender, EventArgs e)
    {
        var nic = GetActiveEthernetOrWifiNetworkInterface().Result;
        if (nic == null)
        {
            MessageBox.Show(@"There is a problem in get network interface information!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        var res = RunCommand($"netsh interface ipv4 set dns \"{nic.Name}\" dhcp");
        if (res)
        {
            MessageBox.Show(@"Dns addresses have been removed", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        MessageBox.Show(@"There is a problem in reset dns addresses!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void dgvDnsList_KeyDown(object sender, KeyEventArgs e)
    {
        if (((DataGridView)sender).SelectedRows.Count > 0 &&
            e.KeyData == Keys.Enter)
        {
            var nic = GetActiveEthernetOrWifiNetworkInterface().Result;
            var preferred = dgvDnsList.SelectedRows[0].Cells["Preferred"].Value.ToString();
            var alternate = dgvDnsList.SelectedRows[0].Cells["Alternate"].Value.ToString();

            btnUnSet_Click(null, null);


            var commandRes = RunCommand(CreateSetCommand(nic.Name, preferred, alternate));
            if (commandRes)
            {
                Clear();

                MessageBox.Show(@"Dns addresses have been changed", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show(@"There is a problem in change dns addresses!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (((DataGridView)sender).SelectedRows.Count > 0 &&
            e.KeyData == Keys.Delete)
        {
            var dialogRes = MessageBox.Show("Are you sure you want delete this item?", string.Empty,
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dialogRes != DialogResult.OK) return;

            var itemId = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells["Id"].Value.ToString());
            _context.Dns.Remove(_context.Dns.Find(itemId));
            var deleteRes = _context.SaveChanges();

            if (deleteRes == 0) return;

            RefreshList();
            MessageBox.Show(@"Dns record have been deleted", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (!_context.Dns.Any(d => d.Preferred == txtPre1.Text &&
                                   d.Alternate == txtAlter1.Text))
        {
            _context.Dns.Add(new Dns()
            {
                Description = txtDescription.Text,
                Preferred = txtPre1.Text,
                Alternate = txtAlter1.Text
            });
            var saveRes = _context.SaveChanges();
            if (saveRes > 0)
            {
                Clear();
                RefreshList();
            }
        }
    }

    private void MainForm_Resize(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Minimized)
        {
            Hide();
            trayIcon.Visible = true;
        }
    }

    private void trayIcon_MouseClick(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
        Show();
        WindowState = FormWindowState.Normal;
        trayIcon.Visible = false;
    }

    private void btnRefreshBox_Click(object sender, EventArgs e)
    {
        RefreshCurrentDnsBox();
    }
}