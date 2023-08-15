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
}
