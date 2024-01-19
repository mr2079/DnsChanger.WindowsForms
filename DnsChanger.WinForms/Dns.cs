using System.ComponentModel.DataAnnotations;

namespace DnsChanger.WinForms;

public class Dns
{
	[Key]
	public int Id { get; set; }

	public string? Description { get; set; }
	public string Preferred { get; set; } = string.Empty;
	public string Alternate { get; set; } = string.Empty;
}