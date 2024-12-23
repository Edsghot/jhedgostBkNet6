using jhedgostBK.Configuration.Shared;
using jhedgostBK.Model.Dtos.User;

namespace jhedgostBK.Modules.User.Application.Port;

public interface IUserOutPort : IBasePresenter<object>
{
    void GetAllUsersAsync(IEnumerable<UserDto> data);
}