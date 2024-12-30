using jhedgostBK.Model.Dtos.CustomerT;
using jhedgostBK.Modules.CustomerTestimonials.Application.Ports;
using jhedgostBK.Modules.CustomerTestimonials.Domain.Entity;
using jhedgostBK.Modules.CustomerTestimonials.Domain.IRepository;
using jhedgostBK.Modules.User.Domain.IRepository;

namespace jhedgostBK.Modules.CustomerTestimonials.Application.Adapter;

public class CustomerTestimonialsAdapter : ICustomerTInputPort
{
    private readonly ICustomerTRepository _customerTRepository;
    private readonly ICustomerTOutPort _customerTOutPort;

    public CustomerTestimonialsAdapter(ICustomerTRepository repository,ICustomerTOutPort userOutPort)
    {
        _customerTRepository = repository;
        _customerTOutPort = userOutPort;
    }
    
    public async Task GetAllAsync()
    {
        var customerT = (await _customerTRepository.GetAllAsync<CustomerTestimonialsEntity>()).ToList();

        if (!customerT.Any())
        {
            _customerTOutPort.NotFound("No Customer found.");
            return;
        }

        var userDtos = customerT.Select(customer => new CustomerTDto
        {
            Id = customer.Id,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            Message = customer.Message,
            Occupation = customer.Occupation
        });
         
        _customerTOutPort.GetAllAsync(userDtos);

    }
}