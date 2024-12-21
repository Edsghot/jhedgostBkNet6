using jhedgostBK.Modules.User.Domain.Entity;

namespace jhedgostBK.Modules.User.Application.Port;

public interface IUserInputPort
{
    Task<IEnumerable<UserEntity>> GetAllUsersAsync();
}