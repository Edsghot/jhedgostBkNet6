using jhedgostBK.Configuration.Context.Repository;
using jhedgostBK.Modules.EmployeeTestimonials.Domain.Entity;
using jhedgostBK.Modules.User.Domain.Entity;

namespace jhedgostBK.Modules.User.Domain.IRepository;

public interface IEmployeeTRepository : IBaseRepository
{
    Task<IEnumerable<EmployeeTestimonialsEntity>> GetAllAsync();
}