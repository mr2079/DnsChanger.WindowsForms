using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace DnsChanger.WinForms;

internal static class Program
{
	private static ServiceProvider ServiceProvider { get; set; } = null!;

	static void ConfigureServices()
	{
		var services = new ServiceCollection();
		services.AddDbContext<ApplicationDbContext>();
		ServiceProvider = services.BuildServiceProvider();
	}

	public static T? GetService<T>() where T : class
		=> ServiceProvider.GetService<T>();

	[STAThread]
	static void Main()
	{
        var currentProcess = Process.GetCurrentProcess();
        var openProcesses = Process.GetProcessesByName(currentProcess.ProcessName);
        if (openProcesses.Any())
			foreach (var p in openProcesses) 
				if (p.Id !=  currentProcess.Id)
                    p.Kill();

        ApplicationConfiguration.Initialize();
		ConfigureServices();
		if (DatabaseConfiguration.Create())
			GetService<ApplicationDbContext>()?.Database.Migrate();
		Application.Run(new MainForm());
	}
}