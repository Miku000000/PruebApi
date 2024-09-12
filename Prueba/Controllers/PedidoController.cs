using PruebaData.DataBase.Tables;
using PruebaData.DataBase;
using Microsoft.AspNetCore.Mvc;
using PruebaData.DataBase;

namespace FibertelApi.Controllers
{
    [ApiController]
    [Route("api/Pedidos")]
    public class PedidoController : ControllerBase
    {
        private readonly MiDbContext _db;
        public PedidoController(MiDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("")]
        public IActionResult ListarPedido()
        {
            var Pedidos = _db.Pedidos.ToList();

            return Ok(Pedidos); //CODIGO DE ESTADO CORRECTO
        }

        /**
        * Creado de nuevo Pedido
        */
        [HttpPost]
        [Route("")]
        public IActionResult CrearPedido([FromBody] Pedido body)
        {
            _db.Pedidos.Add(body);
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
        public IActionResult EliminarPedido([FromRoute] int id)
        {
            // Obtengo el banner y valido su existencia
            var Pedido = _db.Pedidos.Find(id);
            if (Pedido == null)
            {
                return NotFound(); // StatusCode(404);
            }
            // indico que se elimine de la tabla
            _db.Pedidos.Remove(Pedido);
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
        public IActionResult BuscarPedido([FromQuery] string Producto)
        {
            string v2 = Producto ?? "";
            var Pedidos = _db.Pedidos.Where(
                Pedido => Pedido.Producto.Contains(Producto)
                ).ToList();
            return Ok(Pedidos);
        }
    }
}
