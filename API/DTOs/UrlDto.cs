using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs;

public class UrlDto
{
    public string? Text { get; set; }
    public string? Target { get; set; }
    public string? AuthorUsername { get; set; }
}