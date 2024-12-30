using jhedgostBK.Model.Dtos.User;
using jhedgostBK.Modules.User.Domain.Entity;

namespace jhedgostBK.Modules.EmployeeTestimonials.Application.Port;

public interface IEmployeeTInputPort
{
    Task GetAllAsync();
}