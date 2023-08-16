using API.Entities;

namespace API.Interfaces;

public interface IUrlRepository
{
    Task<Url> GetUrlByTextAsync(string text);
    Task AddUrlAsync(Url url);
    Task<string> GenerateUniqueText(string target);
}
