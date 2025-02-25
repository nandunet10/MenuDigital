using Menu.Models;
using Menu.Repositories.Interfaces;

namespace Menu.Repositories.Implementations
{
    public class PedidoRepository : IPedidoRepository
    {
        private static readonly List<Pedido> _pedidos = [];
        private static int _idCounter = 1;

        public Pedido AdicionarPedido(Pedido pedido)
        {
            pedido.Id = _idCounter++;
            _pedidos.Add(pedido);
            return pedido;
        }

        public Pedido ObterPedido(int id)
        {
            return _pedidos.FirstOrDefault(p => p.Id == id)!;
        }

        public void AtualizarPedido(Pedido pedido)
        {
            var pedidoExistente = _pedidos.FirstOrDefault(p => p.Id == pedido.Id);
            if (pedidoExistente != null)
            {
                pedidoExistente.Itens = pedido.Itens;
                pedidoExistente.Total = pedido.Total;
            }
        }

        public void RemoverPedido(int id)
        {
            var pedido = _pedidos.FirstOrDefault(p => p.Id == id);
            if (pedido != null)
            {
                _pedidos.Remove(pedido);
            }
        }
    }
}
