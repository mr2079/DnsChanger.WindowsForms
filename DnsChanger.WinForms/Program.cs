using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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
		=> (T?)ServiceProvider.GetService<T>();

	[STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();
		ConfigureServices();
		if (DatabaseConfiguration.Create())
			GetService<ApplicationDbContext>()?.Database.Migrate();
		Application.Run(new MainForm());
	}
}