using jhedgostBK.Modules.User.Domain.Entity;

namespace jhedgostBK.Modules.User.Domain.IRepository;

public interface IUserRepository
{
    Task<IEnumerable<UserEntity>> GetAllAsync();
}