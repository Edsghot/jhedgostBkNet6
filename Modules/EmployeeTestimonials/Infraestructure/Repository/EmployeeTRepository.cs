using jhedgostBK.Configuration.Context.Repository;
using jhedgostBK.Configuration.DataBase;
using jhedgostBK.Modules.EmployeeTestimonials.Domain.Entity;
using jhedgostBK.Modules.EmployeeTestimonials.Domain.IRepository;
using jhedgostBK.Modules.User.Domain.Entity;
using jhedgostBK.Modules.User.Domain.IRepository;
using Microsoft.EntityFrameworkCore;

namespace jhedgostBK.Modules.EmployeeTestimonials.Infraestructure.Repository;

public class EmployeeTRepository : BaseRepository<MySqlContext>, IEmployeeTRepository
{
    public EmployeeTRepository(MySqlContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<EmployeeTestimonialsEntity>> GetAllAsync()
    {
        return await _context.EmployeeTestimonials.ToListAsync();
    }
}