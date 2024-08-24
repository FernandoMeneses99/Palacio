using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Palacio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // Este método maneja la solicitud de inicio de sesión
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
        {

            if (request.Correo == "admin" && request.Clave == "password") 
            {
                return Ok(new { Token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..." });
            }

            return Unauthorized();
        }
    }

    // Modelo para la solicitud de inicio de sesión
    public class LoginRequest
    {
        public string Correo { get; set; }
        public string Clave { get; set; }
    }
}
