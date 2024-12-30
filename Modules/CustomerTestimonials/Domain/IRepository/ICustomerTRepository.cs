using jhedgostBK.Configuration.Context.Repository;
using jhedgostBK.Modules.CustomerTestimonials.Domain.Entity;
using jhedgostBK.Modules.User.Domain.Entity;

namespace jhedgostBK.Modules.CustomerTestimonials.Domain.IRepository;

public interface ICustomerTRepository : IBaseRepository
{
    Task<IEnumerable<CustomerTestimonialsEntity>> GetAllAsync();
}