using jhedgostBK.Configuration.Context.Repository;
using jhedgostBK.Modules.User.Domain.Entity;

namespace jhedgostBK.Modules.User.Domain.IRepository;

public interface IUserRepository : IBaseRepository
{
    Task<IEnumerable<UserEntity>> GetAllAsync();
}