using PruebaData.DataBase.Tables;
using PruebaData.DataBase;
using Microsoft.AspNetCore.Mvc;
using PruebaData.DataBase;

namespace Prueba.Controllers
{
    [ApiController]
    [Route("api/Personas")]
    public class PersonaController : ControllerBase
    {
        private readonly MiDbContext _db;
        public PersonaController(MiDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("")]
        public IActionResult ListarPersona()
        {
            var personas = _db.Personas.ToList();

            return Ok(personas); //CODIGO DE ESTADO CORRECTO
        }

        /**
        * Creado de nuevo Persona
        */
        [HttpPost]
        [Route("")]
        public IActionResult CrearPersona([FromBody] Persona body)
        {
            _db.Personas.Add(body);
            int r = _db.SaveChanges();
            if (r != 1)
            {
                return StatusCode(500); //StatusCode(500); ERROR DE CODIGO DEL SERVIDOR
            }
            //return NoContent(); //StatusCode 204; ESTADO DE CODIGO CORRECTO
            return Ok(body);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult EliminarPersona([FromRoute] int id)
        {
            // Obtengo el banner y valido su existencia
            var Persona = _db.Personas.Find(id);
            if (Persona == null)
            {
                return NotFound(); // StatusCode(404);
            }
            // indico que se elimine de la tabla
            _db.Personas.Remove(Persona);
            // Aplico los cambios a la BD
            int r = _db.SaveChanges();

            // Verifico que se hayan efectuado estos cambios
            if (r != 1)
            {
                return StatusCode(500);
            }
            return NoContent(); //StatusCode 204
        }
        [HttpGet]
        [Route("Buscar")]
        public IActionResult BuscarPersona([FromQuery] string ApellidoP)
        {
            string v2 = ApellidoP ?? "";
            var Personas = _db.Personas.Where(
                Persona => Persona.apellidoPaterno.Contains(ApellidoP)
                ).ToList();
            return Ok(Personas);
        }
    }
}
