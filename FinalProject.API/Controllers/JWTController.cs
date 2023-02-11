using FinalProject.Core.Data;
using FinalProject.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JWTController : ControllerBase
    {
        private readonly IJWTService jWTService;
        public JWTController(IJWTService jWTService) 
        {
            this.jWTService= jWTService;
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Auth([FromBody] User login)
        {
            var token = jWTService.Auth(login);
            if(token == null)
            {
                return Unauthorized("NOT OK");
            }
            else
            {
                return Ok(token);
            }
        }
        
    }
}
