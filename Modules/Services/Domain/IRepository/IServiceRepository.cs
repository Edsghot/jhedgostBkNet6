using jhedgostBK.Configuration.Context.Repository;
using jhedgostBK.Modules.EmployeeTestimonials.Domain.Entity;
using jhedgostBK.Modules.Services.Domain.Entity;

namespace jhedgostBK.Modules.services.Domain.IRepository;

public interface IServiceRepository : IBaseRepository
{
    Task<IEnumerable<ServiceEntity>> GetAllAsync();
}