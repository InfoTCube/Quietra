namespace API.Entities;

public class UrlView
{
    public int Id { get; set; }
    public Url? url { get; set; }
    public string? IpAddress { get; set; }
    public string? Browser { get; set; }
    public string? Os { get; set; }
    public string? Device { get; set; }
    public string? Country { get; set; }
}