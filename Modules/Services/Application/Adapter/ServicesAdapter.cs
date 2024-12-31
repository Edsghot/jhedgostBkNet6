
using jhedgostBK.Model.Dtos.Service;
using jhedgostBK.Modules.EmployeeTestimonials.Domain.Entity;
using jhedgostBK.Modules.services.Application.Port;
using jhedgostBK.Modules.Services.Domain.Entity;
using jhedgostBK.Modules.services.Domain.IRepository;

namespace jhedgostBK.Modules.Services.Application.Adapter;

public class ServicesAdapter: IServiceInputPort
{
    private readonly IServiceRepository _serviceRepository;
    private readonly IServiceOutPort _serviceOutPort;

    public ServicesAdapter(IServiceRepository repository,IServiceOutPort serviceOutPort)
    {
        _serviceRepository = repository;
        _serviceOutPort = serviceOutPort;
    }
    
     public async Task GetAllAsync()
     {
         var services = (await _serviceRepository.GetAllAsync<ServiceEntity>()).ToList();

         if (!services.Any())
         {
             _serviceOutPort.NotFound("No services found.");
             return;
         }

         var serviceDtos = services.Select(x => new ServiceDto
         {
             Id = x.Id,
             Name = x.Name,
             Description = x.Description,
         });
         
         _serviceOutPort.GetAllAsync(serviceDtos);
    }
}