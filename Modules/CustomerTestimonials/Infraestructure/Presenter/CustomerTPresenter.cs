using jhedgostBK.Configuration.Shared;
using jhedgostBK.Model.Dtos.CustomerT;
using jhedgostBK.Model.Dtos.Response;
using jhedgostBK.Model.Dtos.User;
using jhedgostBK.Modules.CustomerTestimonials.Application.Ports;
using jhedgostBK.Modules.User.Application.Port;

namespace jhedgostBK.Modules.CustomerTestimonials.Infraestructure.Presenter;

public class CustomerTPresenter : BasePresenter<object>, ICustomerTOutPort
{

    public void GetAllAsync(IEnumerable<CustomerTDto> data)
    {
        throw new NotImplementedException();
    }
}