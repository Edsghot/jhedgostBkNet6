using jhedgostBK.Configuration.Shared;
using jhedgostBK.Model.Dtos.Response;
using jhedgostBK.Model.Dtos.User;
using jhedgostBK.Modules.User.Application.Port;

namespace jhedgostBK.Modules.User.Infraestructure.Presenter;

public class UserPresenter : BasePresenter<object>, IUserOutPort
{
    public void GetAllUsersAsync(IEnumerable<UserDto> data)
    {
        Success(data, "Users successfully retrieved.");
    }

    public void NotFound(string message = "Data not found")
    {
        base.NotFound(message);
    }
}