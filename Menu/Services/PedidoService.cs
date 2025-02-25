using Menu.Models;
using Menu.Repositories.Interfaces;

namespace Menu.Services
{
    public class PedidoService(IPedidoRepository pedidoRepository)
    {
        public Pedido BuscarPedido(int pedidoId)
        {
            return pedidoRepository.ObterPedido(pedidoId);
        }
        public Pedido CriarPedido(List<MenuItem> itens)
        {
            var pedido = new Pedido { Itens = itens, Total = itens.Sum(item => item.Preco) };
            var retornoPedido = pedidoRepository.AdicionarPedido(pedido);
            return retornoPedido;
        }

        public void CancelarPedido(int pedidoId)
        {
            pedidoRepository.RemoverPedido(pedidoId);
        }

        public void EditarPedido(int pedidoId, List<MenuItem> novosItens)
        {
            var pedido = pedidoRepository.ObterPedido(pedidoId);
            pedido.Itens = novosItens;
            pedido.Total = novosItens.Sum(item => item.Preco);
            pedidoRepository.AtualizarPedido(pedido);
        }
    }

}
