using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Servidor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServidorController : ControllerBase
    {
        public static List<Consulta> consultas = new List<Consulta>();

        [HttpPost("upload")]
        public IActionResult Upload([FromBody] Consulta consulta)
        {
            consultas.Add(consulta);
            return Ok("Añadido con exito");
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(consultas);
        }
    }
}
