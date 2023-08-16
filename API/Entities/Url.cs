using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities;

[Table("Urls")]
public class Url
{
    public int Id { get; set; }
    public string? Text { get; set; }
    public string? Target { get; set; }
    public AppUser? Author { get; set; }
    public ICollection<UrlView>? Views { get; set; }
}