namespace DnsChanger.WinForms;

public class DatabaseConfiguration
{
	public static string dbName = "dns.db";
	public static string directoryName = @"dns-changer\database";
	public static string dbPath = Path.Combine(
		Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
		directoryName,
		dbName
	);
	public static string dbDirectory = Path.Combine(
		Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
		directoryName
	);
	public static bool Create()
	{
		try
		{
			if (!Directory.Exists(dbDirectory)) Directory.CreateDirectory(dbDirectory);
			if (!File.Exists(dbPath)) File.Create(dbPath);
			return true;
		}
		catch { return false; }
	}
}