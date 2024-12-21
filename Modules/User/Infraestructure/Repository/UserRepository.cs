using jhedgostBK.Configuration.DataBase;
using jhedgostBK.Modules.User.Domain.Entity;
using jhedgostBK.Modules.User.Domain.IRepository;
using Microsoft.EntityFrameworkCore;

namespace jhedgostBK.Modules.User.Infraestructure.Repository;

public class UserRepository : IUserRepository
{
    private readonly MySqlContext _context;

    public UserRepository(MySqlContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<UserEntity>> GetAllAsync()
    {
        return await _context.Users.ToListAsync();
    }
}