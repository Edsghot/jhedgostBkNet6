using jhedgostBK.Configuration.Context.Repository;
using jhedgostBK.Modules.EmployeeTestimonials.Domain.Entity;

namespace jhedgostBK.Modules.EmployeeTestimonials.Domain.IRepository;

public interface IEmployeeTRepository : IBaseRepository
{
    Task<IEnumerable<EmployeeTestimonialsEntity>> GetAllAsync();
}