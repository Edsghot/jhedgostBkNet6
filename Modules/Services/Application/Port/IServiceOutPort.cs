using jhedgostBK.Configuration.Shared;
using jhedgostBK.Model.Dtos.EmployeeT;
using jhedgostBK.Model.Dtos.Service;
using jhedgostBK.Model.Dtos.User;

namespace jhedgostBK.Modules.services.Application.Port;

public interface IServiceOutPort : IBasePresenter<object>
{
    void GetAllAsync(IEnumerable<ServiceDto> data);
}