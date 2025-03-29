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

        [HttpGet("token")]
        public IActionResult GetByToken(string token, string hospital)
        {
            Consulta last = consultas.Where(c => c.hospital == hospital && c.token == token).Last();
            if (last == null) { return BadRequest("El token no existe"); }
            return Ok(last);
        }

        [HttpGet("profesional")]
        public IActionResult GetByProffesional(string nombre, string apellido, string hospital)
        {
            int catidad = consultas.Where(c => c.hospital == hospital && c.nombreProfesional.ToUpper().Trim() == nombre.ToUpper().Trim() && c.apellidoProfesional.ToUpper().Trim() == apellido.ToUpper().Trim()).Count();
            return Ok(catidad);
        }

        [HttpDelete]
        public IActionResult Delete(int turno)
        {
            consultas.Remove(consultas.Where(c => c.turno == turno).Last());
            return Ok("Removido con éxito");
        }
    }
}
