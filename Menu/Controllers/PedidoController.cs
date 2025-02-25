using Menu.Models;
using Menu.Services;
using Microsoft.AspNetCore.Mvc;

namespace Menu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController(PedidoService pedidoService) : ControllerBase
    {
        [HttpGet]
        public IActionResult BuscarPedido(int id)
        {
            var pedido = pedidoService.BuscarPedido(id);
            return Ok(pedido);
        }

        [HttpPost]
        public IActionResult CriarPedido([FromBody] List<MenuItem> itens)
        {
            var pedido = pedidoService.CriarPedido(itens);
            return Ok(pedido);
        }

        [HttpDelete("{id}")]
        public IActionResult CancelarPedido(int id)
        {
            pedidoService.CancelarPedido(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult EditarPedido(int id, [FromBody] List<MenuItem> itens)
        {
            pedidoService.EditarPedido(id, itens);
            return NoContent();
        }
    }

}
