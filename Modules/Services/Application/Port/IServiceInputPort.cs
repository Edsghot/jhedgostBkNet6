using jhedgostBK.Model.Dtos.User;
using jhedgostBK.Modules.User.Domain.Entity;

namespace jhedgostBK.Modules.services.Application.Port;

public interface IServiceInputPort
{
    Task GetAllAsync();
}