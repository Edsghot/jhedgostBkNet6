using jhedgostBK.Configuration.Context.Repository;
using jhedgostBK.Configuration.DataBase;
using jhedgostBK.Modules.CustomerTestimonials.Domain.Entity;
using jhedgostBK.Modules.CustomerTestimonials.Domain.IRepository;
using jhedgostBK.Modules.User.Domain.Entity;
using jhedgostBK.Modules.User.Domain.IRepository;
using Microsoft.EntityFrameworkCore;

namespace jhedgostBK.Modules.CustomerTestimonials.Infraestructure.Repository;

public class CustomerTRepository : BaseRepository<MySqlContext>, ICustomerTRepository
{
    public CustomerTRepository(MySqlContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<CustomerTestimonialsEntity>> GetAllAsync()
    {
        return await _context.CustomerTestimonials.ToListAsync();
    }
}