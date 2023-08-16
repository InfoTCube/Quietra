using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class UrlRepository : IUrlRepository
{
    private readonly IMapper _mapper;
    private readonly DataContext _context;
    public UrlRepository(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Url> GetUrlByTextAsync(string text)
    {
        return await _context.Urls.Where(url => url.Text == text).FirstOrDefaultAsync();
    }

    public async Task AddUrlAsync(Url url)
    {
        await _context.Urls.AddAsync(url);
    }

    public async Task<string> GenerateUniqueText(string target)
    {

        Url existingUrl = _context.Urls.Where(url => url.Target == target).FirstOrDefault();
        if(existingUrl != null) return existingUrl.Text;

        string text = string.Empty;
        do
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[6];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            text = new String(stringChars);
        } while(_context.Urls.Where(url => url.Text == text) == null);

        return text;
    }
}
