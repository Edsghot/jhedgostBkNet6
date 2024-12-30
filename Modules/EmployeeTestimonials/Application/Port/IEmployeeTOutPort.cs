using jhedgostBK.Configuration.Shared;
using jhedgostBK.Model.Dtos.EmployeeT;
using jhedgostBK.Model.Dtos.User;

namespace jhedgostBK.Modules.EmployeeTestimonials.Application.Port;

public interface IEmployeeTOutPort : IBasePresenter<object>
{
    void GetAllAsync(IEnumerable<EmployeeTDto> data);
}