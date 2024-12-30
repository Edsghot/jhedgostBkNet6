using jhedgostBK.Model.Dtos.User;
using jhedgostBK.Modules.EmployeeTestimonials.Application.Port;
using jhedgostBK.Modules.User.Application.Port;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace jhedgostBK.Modules.EmployeeTestimonials.Infraestructure.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTestimonialsController : ControllerBase
    {
        private readonly IEmployeeTInputPort _employeeTInputPort;
        private readonly IEmployeeTOutPort _employeeOutPort;

        public EmployeeTestimonialsController(IEmployeeTInputPort employeeTInputPort, IEmployeeTOutPort employeeOutPort)
        {
            _employeeTInputPort = employeeTInputPort;
            _employeeOutPort = employeeOutPort;            
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _employeeTInputPort.GetAllAsync();
            var response = _employeeOutPort.GetResponse;

            if (response is null || !response.Success)
            {
                return NotFound(new { Message = response?.Message ?? "Employee testimonials not found" });
            }

            return Ok(response);
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
