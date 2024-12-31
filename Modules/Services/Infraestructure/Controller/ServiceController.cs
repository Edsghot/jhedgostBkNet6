using jhedgostBK.Model.Dtos.User;
using jhedgostBK.Modules.EmployeeTestimonials.Application.Port;
using jhedgostBK.Modules.services.Application.Port;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace jhedgostBK.Modules.Services.Infraestructure.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceInputPort _serviceInputPort;
        private readonly IServiceOutPort _serviceOutPort;

        public ServiceController(IServiceInputPort serviceInputPort, IServiceOutPort serviceOutPort)
        {
            _serviceInputPort = serviceInputPort;
            _serviceOutPort = serviceOutPort;            
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            await _serviceInputPort.GetAllAsync();

            return Ok(_serviceOutPort.GetResponse);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
