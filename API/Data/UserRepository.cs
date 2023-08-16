using API.Entities;
using API.Interfaces;

namespace API.Data;

public class UserRepository : IUserRepository
{
    private readonly DataContext _context;

    public UserRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<AppUser> GetUserByUsernameAsync(string username)
    {
        return _context.Users.FirstOrDefault(user => user.UserName == username);
    }
}
