using Menu.Models;

namespace Menu.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        Pedido AdicionarPedido(Pedido pedido);
        Pedido ObterPedido(int id);
        void AtualizarPedido(Pedido pedido);
        void RemoverPedido(int id);
    }
}
