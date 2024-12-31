using jhedgostBK.Configuration.Context.Repository;
using jhedgostBK.Configuration.DataBase;
using jhedgostBK.Modules.EmployeeTestimonials.Domain.Entity;
using jhedgostBK.Modules.Services.Domain.Entity;
using jhedgostBK.Modules.services.Domain.IRepository;
using jhedgostBK.Modules.User.Domain.Entity;
using jhedgostBK.Modules.User.Domain.IRepository;
using Microsoft.EntityFrameworkCore;

namespace jhedgostBK.Modules.Services.Infraestructure.Repository;

public class ServiceRepository : BaseRepository<MySqlContext>, IServiceRepository
{
    public ServiceRepository(MySqlContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<ServiceEntity>> GetAllAsync()
    {
        return await _context.Services.ToListAsync();
    }
}