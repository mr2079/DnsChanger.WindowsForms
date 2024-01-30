namespace DnsChanger.WinForms
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			btnUnSet = new Button();
			dgvDnsList = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Preferred = new DataGridViewTextBoxColumn();
			Alternate = new DataGridViewTextBoxColumn();
			Description = new DataGridViewTextBoxColumn();
			txtDescription = new TextBox();
			txtPre1 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			txtPre2 = new TextBox();
			txtPre3 = new TextBox();
			txtPre4 = new TextBox();
			txtAlter4 = new TextBox();
			txtAlter3 = new TextBox();
			txtAlter2 = new TextBox();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			txtAlter1 = new TextBox();
			btnSave = new Button();
			trayIcon = new NotifyIcon(components);
			gbCurrent = new GroupBox();
			lblCurrentAlternate = new Label();
			lblCurrentPreferred = new Label();
			label11 = new Label();
			label10 = new Label();
			btnRefreshBox = new Button();
			btnExit = new Button();
			((System.ComponentModel.ISupportInitialize)dgvDnsList).BeginInit();
			gbCurrent.SuspendLayout();
			SuspendLayout();
			// 
			// btnUnSet
			// 
			btnUnSet.Location = new Point(13, 428);
			btnUnSet.Name = "btnUnSet";
			btnUnSet.Size = new Size(339, 23);
			btnUnSet.TabIndex = 1;
			btnUnSet.Text = "Reset";
			btnUnSet.UseVisualStyleBackColor = true;
			btnUnSet.Click += btnUnSet_Click;
			// 
			// dgvDnsList
			// 
			dgvDnsList.AllowUserToAddRows = false;
			dgvDnsList.AllowUserToDeleteRows = false;
			dgvDnsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvDnsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDnsList.Columns.AddRange(new DataGridViewColumn[] { Id, Preferred, Alternate, Description });
			dgvDnsList.Location = new Point(12, 107);
			dgvDnsList.Name = "dgvDnsList";
			dgvDnsList.ReadOnly = true;
			dgvDnsList.Size = new Size(339, 177);
			dgvDnsList.TabIndex = 2;
			dgvDnsList.RowHeaderMouseDoubleClick += dgvDnsList_RowHeaderMouseDoubleClick;
			dgvDnsList.KeyDown += dgvDnsList_KeyDown;
			// 
			// Id
			// 
			Id.DataPropertyName = "Id";
			Id.HeaderText = "Id";
			Id.Name = "Id";
			Id.ReadOnly = true;
			Id.Visible = false;
			// 
			// Preferred
			// 
			Preferred.DataPropertyName = "Preferred";
			Preferred.HeaderText = "Preferred";
			Preferred.Name = "Preferred";
			Preferred.ReadOnly = true;
			// 
			// Alternate
			// 
			Alternate.DataPropertyName = "Alternate";
			Alternate.HeaderText = "Alternate";
			Alternate.Name = "Alternate";
			Alternate.ReadOnly = true;
			// 
			// Description
			// 
			Description.DataPropertyName = "Description";
			Description.HeaderText = "Description";
			Description.Name = "Description";
			Description.ReadOnly = true;
			// 
			// txtDescription
			// 
			txtDescription.Location = new Point(97, 302);
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(254, 23);
			txtDescription.TabIndex = 3;
			txtDescription.TextAlign = HorizontalAlignment.Center;
			// 
			// txtPre1
			// 
			txtPre1.Location = new Point(97, 331);
			txtPre1.Name = "txtPre1";
			txtPre1.Size = new Size(254, 23);
			txtPre1.TabIndex = 4;
			txtPre1.TextAlign = HorizontalAlignment.Center;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 305);
			label1.Name = "label1";
			label1.Size = new Size(67, 15);
			label1.TabIndex = 6;
			label1.Text = "Description";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 334);
			label2.Name = "label2";
			label2.Size = new Size(55, 15);
			label2.TabIndex = 7;
			label2.Text = "Preferred";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 363);
			label3.Name = "label3";
			label3.Size = new Size(55, 15);
			label3.TabIndex = 8;
			label3.Text = "Alternate";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(141, 334);
			label4.Name = "label4";
			label4.Size = new Size(10, 15);
			label4.TabIndex = 10;
			label4.Text = ".";
			label4.Visible = false;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(213, 334);
			label5.Name = "label5";
			label5.Size = new Size(10, 15);
			label5.TabIndex = 11;
			label5.Text = ".";
			label5.Visible = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(285, 334);
			label6.Name = "label6";
			label6.Size = new Size(10, 15);
			label6.TabIndex = 13;
			label6.Text = ".";
			label6.Visible = false;
			// 
			// txtPre2
			// 
			txtPre2.Location = new Point(157, 331);
			txtPre2.Name = "txtPre2";
			txtPre2.Size = new Size(50, 23);
			txtPre2.TabIndex = 5;
			txtPre2.Visible = false;
			// 
			// txtPre3
			// 
			txtPre3.Location = new Point(229, 331);
			txtPre3.Name = "txtPre3";
			txtPre3.Size = new Size(50, 23);
			txtPre3.TabIndex = 6;
			txtPre3.Visible = false;
			// 
			// txtPre4
			// 
			txtPre4.Location = new Point(301, 331);
			txtPre4.Name = "txtPre4";
			txtPre4.Size = new Size(50, 23);
			txtPre4.TabIndex = 7;
			txtPre4.Visible = false;
			// 
			// txtAlter4
			// 
			txtAlter4.Location = new Point(301, 360);
			txtAlter4.Name = "txtAlter4";
			txtAlter4.Size = new Size(50, 23);
			txtAlter4.TabIndex = 11;
			txtAlter4.Visible = false;
			// 
			// txtAlter3
			// 
			txtAlter3.Location = new Point(229, 360);
			txtAlter3.Name = "txtAlter3";
			txtAlter3.Size = new Size(50, 23);
			txtAlter3.TabIndex = 10;
			txtAlter3.Visible = false;
			// 
			// txtAlter2
			// 
			txtAlter2.Location = new Point(157, 360);
			txtAlter2.Name = "txtAlter2";
			txtAlter2.Size = new Size(50, 23);
			txtAlter2.TabIndex = 9;
			txtAlter2.Visible = false;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(285, 363);
			label7.Name = "label7";
			label7.Size = new Size(10, 15);
			label7.TabIndex = 20;
			label7.Text = ".";
			label7.Visible = false;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(213, 363);
			label8.Name = "label8";
			label8.Size = new Size(10, 15);
			label8.TabIndex = 19;
			label8.Text = ".";
			label8.Visible = false;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(141, 363);
			label9.Name = "label9";
			label9.Size = new Size(10, 15);
			label9.TabIndex = 18;
			label9.Text = ".";
			label9.Visible = false;
			// 
			// txtAlter1
			// 
			txtAlter1.Location = new Point(97, 360);
			txtAlter1.Name = "txtAlter1";
			txtAlter1.Size = new Size(254, 23);
			txtAlter1.TabIndex = 8;
			txtAlter1.TextAlign = HorizontalAlignment.Center;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(12, 399);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(339, 23);
			btnSave.TabIndex = 12;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// trayIcon
			// 
			trayIcon.Icon = (Icon)resources.GetObject("trayIcon.Icon");
			trayIcon.Text = "Dns Changer";
			trayIcon.MouseClick += trayIcon_MouseClick;
			// 
			// gbCurrent
			// 
			gbCurrent.Controls.Add(lblCurrentAlternate);
			gbCurrent.Controls.Add(lblCurrentPreferred);
			gbCurrent.Controls.Add(label11);
			gbCurrent.Controls.Add(label10);
			gbCurrent.Location = new Point(12, 12);
			gbCurrent.Name = "gbCurrent";
			gbCurrent.Size = new Size(267, 80);
			gbCurrent.TabIndex = 21;
			gbCurrent.TabStop = false;
			gbCurrent.Text = "Current";
			// 
			// lblCurrentAlternate
			// 
			lblCurrentAlternate.AutoSize = true;
			lblCurrentAlternate.Location = new Point(85, 50);
			lblCurrentAlternate.Name = "lblCurrentAlternate";
			lblCurrentAlternate.Size = new Size(39, 15);
			lblCurrentAlternate.TabIndex = 23;
			lblCurrentAlternate.Text = "DHCP";
			// 
			// lblCurrentPreferred
			// 
			lblCurrentPreferred.AutoSize = true;
			lblCurrentPreferred.Location = new Point(85, 26);
			lblCurrentPreferred.Name = "lblCurrentPreferred";
			lblCurrentPreferred.Size = new Size(39, 15);
			lblCurrentPreferred.TabIndex = 22;
			lblCurrentPreferred.Text = "DHCP";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(6, 50);
			label11.Name = "label11";
			label11.Size = new Size(55, 15);
			label11.TabIndex = 22;
			label11.Text = "Alternate";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(6, 26);
			label10.Name = "label10";
			label10.Size = new Size(55, 15);
			label10.TabIndex = 22;
			label10.Text = "Preferred";
			// 
			// btnRefreshBox
			// 
			btnRefreshBox.Location = new Point(286, 52);
			btnRefreshBox.Name = "btnRefreshBox";
			btnRefreshBox.Size = new Size(66, 40);
			btnRefreshBox.TabIndex = 24;
			btnRefreshBox.Text = "Refresh";
			btnRefreshBox.UseVisualStyleBackColor = true;
			btnRefreshBox.Click += btnRefreshBox_Click;
			// 
			// btnExit
			// 
			btnExit.Location = new Point(286, 12);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(66, 40);
			btnExit.TabIndex = 25;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			ClientSize = new Size(364, 461);
			Controls.Add(btnExit);
			Controls.Add(btnRefreshBox);
			Controls.Add(gbCurrent);
			Controls.Add(btnSave);
			Controls.Add(txtAlter4);
			Controls.Add(txtAlter3);
			Controls.Add(txtAlter2);
			Controls.Add(label7);
			Controls.Add(label8);
			Controls.Add(label9);
			Controls.Add(txtAlter1);
			Controls.Add(txtPre4);
			Controls.Add(txtPre3);
			Controls.Add(txtPre2);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtPre1);
			Controls.Add(txtDescription);
			Controls.Add(dgvDnsList);
			Controls.Add(btnUnSet);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Dns Changer";
			FormClosing += MainForm_FormClosing;
			Load += MainForm_Load;
			Resize += MainForm_Resize;
			((System.ComponentModel.ISupportInitialize)dgvDnsList).EndInit();
			gbCurrent.ResumeLayout(false);
			gbCurrent.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnUnSet;
		private DataGridView dgvDnsList;
		private TextBox txtDescription;
		private TextBox txtPre1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox txtPre2;
		private TextBox txtPre3;
		private TextBox txtPre4;
		private TextBox txtAlter4;
		private TextBox txtAlter3;
		private TextBox txtAlter2;
		private Label label7;
		private Label label8;
		private Label label9;
		private TextBox txtAlter1;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Preferred;
		private DataGridViewTextBoxColumn Alternate;
		private DataGridViewTextBoxColumn Description;
		private Button btnSave;
		private NotifyIcon trayIcon;
		private GroupBox gbCurrent;
		private Label label11;
		private Label label10;
		private Label lblCurrentAlternate;
		private Label lblCurrentPreferred;
		private Button btnRefreshBox;
		private Button btnExit;
	}
}
