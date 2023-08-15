using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace API.Entities;

public class AppUser : IdentityUser<int>
{
    public ICollection<Url>? Urls { get; set; }
    public ICollection<AppUserRole>? UserRoles { get; set; }
}
