using jhedgostBK.Configuration.Shared;
using jhedgostBK.Model.Dtos.CustomerT;

namespace jhedgostBK.Modules.CustomerTestimonials.Application.Ports;

public interface ICustomerTOutPort: IBasePresenter<object>
{
    void GetAllAsync(IEnumerable<CustomerTDto> data);
}