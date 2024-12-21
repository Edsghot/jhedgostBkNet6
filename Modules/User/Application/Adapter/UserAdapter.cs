using jhedgostBK.Modules.User.Application.Port;
using jhedgostBK.Modules.User.Domain.Entity;
using jhedgostBK.Modules.User.Domain.IRepository;

namespace jhedgostBK.Modules.User.Application.Adapter;

public class UserAdapter: IUserInputPort
{
    private readonly IUserRepository _userRepository;

    public UserAdapter(IUserRepository repository)
    {
        _userRepository = repository;
    }
    
     public async Task<IEnumerable<UserEntity>> GetAllUsersAsync()
        {
            // Lógica para obtener todos los usuarios del repositorio
            return await _userRepository.GetAllAsync();
        }
}