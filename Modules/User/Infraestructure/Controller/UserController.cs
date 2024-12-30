﻿using jhedgostBK.Model.Dtos.User;
using jhedgostBK.Modules.User.Application.Port;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace jhedgostBK.Modules.User.Infraestructure.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserInputPort _userInputPort;
        private readonly IUserOutPort _userOutPort;

        public UserController(IUserInputPort userInputPort, IUserOutPort userOutPort)
        {
            _userInputPort = userInputPort;
            _userOutPort = userOutPort;            
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _userInputPort.GetAllUsersAsync();
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
