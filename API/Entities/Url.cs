using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities;

[Table("Urls")]
public class Url
{
    public int Id { get; set; }
    public string Text { get; set; }
    public string Target { get; set; }
    public AppUser Author { get; set; }
}