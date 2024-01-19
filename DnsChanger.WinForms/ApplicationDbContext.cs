using Microsoft.EntityFrameworkCore;

namespace DnsChanger.WinForms;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext() {}
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
		base(options) {}

	public DbSet<Dns> Dns { get; set; } = null!;

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite($"Data Source={DatabaseConfiguration.dbPath}");

		base.OnConfiguring(optionsBuilder);
	}
}