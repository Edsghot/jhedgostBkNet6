using jhedgostBK.Model.Dtos.User;
using jhedgostBK.Modules.CustomerTestimonials.Application.Ports;
using jhedgostBK.Modules.User.Application.Port;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace jhedgostBK.Modules.CustomerTestimonials.Infraestructure.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerTestimonialsController : ControllerBase
    {
        private readonly ICustomerTInputPort _userInputPort;
        private readonly ICustomerTOutPort _userOutPort;

        public CustomerTestimonialsController(ICustomerTInputPort customerInputPort, ICustomerTOutPort customerTOutPort)
        {
            _userInputPort = customerInputPort;
            _userOutPort = customerTOutPort;            
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            await _userInputPort.GetAllAsync();
            var response = _userOutPort.GetResponse;

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
