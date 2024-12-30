using jhedgostBK.Configuration.Shared;
using jhedgostBK.Model.Dtos.EmployeeT;
using jhedgostBK.Model.Dtos.Response;
using jhedgostBK.Model.Dtos.User;
using jhedgostBK.Modules.EmployeeTestimonials.Application.Port;
using jhedgostBK.Modules.User.Application.Port;

namespace jhedgostBK.Modules.EmployeeTestimonials.Infraestructure.Presenter;

public class EmployeeTPresenter : BasePresenter<object>, IEmployeeTOutPort
{
    public void GetAllAsync(IEnumerable<EmployeeTDto> data)
    {
        Success(data, "Employee testimonials successfully retrieved.");
    }
    
}