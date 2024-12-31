using jhedgostBK.Model.Dtos.EmployeeT;
using jhedgostBK.Modules.EmployeeTestimonials.Application.Port;
using jhedgostBK.Modules.EmployeeTestimonials.Domain.Entity;
using jhedgostBK.Modules.EmployeeTestimonials.Domain.IRepository;

namespace jhedgostBK.Modules.EmployeeTestimonials.Application.Adapter;

public class EmployeeTAdapter: IEmployeeTInputPort
{
    private readonly IEmployeeTRepository _employeeTRepository;
    private readonly IEmployeeTOutPort _employeeTOutPort;

    public EmployeeTAdapter(IEmployeeTRepository repository,IEmployeeTOutPort employeeTOutPort)
    {
        _employeeTRepository = repository;
        _employeeTOutPort = employeeTOutPort;
    }
    
     public async Task GetAllAsync()
     {
         var employeeT = (await _employeeTRepository.GetAllAsync<EmployeeTestimonialsEntity>()).ToList();

         if (!employeeT.Any())
         {
             _employeeTOutPort.NotFound("No Employee testimonials found.");
             return;
         }

         var employeeTDtos = employeeT.Select(x => new EmployeeTDto
         {
             Id = x.Id,
             FirstName = x.FirstName,
             LastName = x.LastName,
             Message = x.Message,
             Occupation = x.Occupation
         });
         
         _employeeTOutPort.GetAllAsync(employeeTDtos);

     }
}