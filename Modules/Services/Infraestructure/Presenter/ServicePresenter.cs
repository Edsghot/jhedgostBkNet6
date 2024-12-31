using jhedgostBK.Configuration.Shared;
using jhedgostBK.Model.Dtos.EmployeeT;
using jhedgostBK.Model.Dtos.Response;
using jhedgostBK.Model.Dtos.Service;
using jhedgostBK.Model.Dtos.User;
using jhedgostBK.Modules.EmployeeTestimonials.Application.Port;
using jhedgostBK.Modules.services.Application.Port;
using jhedgostBK.Modules.User.Application.Port;

namespace jhedgostBK.Modules.Services.Infraestructure.Presenter;

public class ServicePresenter : BasePresenter<object>, IServiceOutPort
{
    public void GetAllAsync(IEnumerable<ServiceDto> data)
    {
        Success(data, "services successfully retrieved.");
    }
    
}