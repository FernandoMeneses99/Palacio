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
            // Aquí debes implementar la lógica de autenticación.
            // Puedes validar el usuario con una base de datos, por ejemplo.

            if (request.Username == "admin" && request.Password == "password") // Ejemplo básico
            {
                // Si la autenticación es exitosa, puedes devolver un token JWT u otra respuesta
                return Ok(new { Token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..." });
            }

            // Si la autenticación falla, devuelves un error
            return Unauthorized();
        }
    }

    // Modelo para la solicitud de inicio de sesión
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
