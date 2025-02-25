using Menu.Models;
using Menu.Repositories.Interfaces;
using Menu.Services;
using Moq;

namespace MenuDigital.Tests.Tests
{
    public class PedidoServiceTests
    {
        private readonly PedidoService _pedidoService;
        private readonly Mock<IPedidoRepository> _pedidoRepositoryMock;

        public PedidoServiceTests()
        {
            _pedidoRepositoryMock = new Mock<IPedidoRepository>();
            _pedidoService = new PedidoService(_pedidoRepositoryMock.Object);
        }

        [Fact]
        public void CriarPedido_ShouldReturnPedidoComItens()
        {
            // Arrange
            var menuItems = new List<MenuItem>
            {
                new() { Id = 1, Nome = "Pizza", Preco = 20.00m },
                new() { Id = 2, Nome = "Hamburguer", Preco = 15.00m }
            };

            var pedidoNovo = new Pedido { Itens = menuItems, Total = menuItems.Sum(item => item.Preco) };
            _pedidoRepositoryMock.Setup(repo => repo.AdicionarPedido(It.IsAny<Pedido>())).Returns(pedidoNovo);


            // Act
            var pedido = _pedidoService.CriarPedido(menuItems);

            // Assert
            Assert.NotNull(pedido);
            Assert.Equal(2, pedido.Itens.Count);
            Assert.Equal(35.00m, pedido.Total);

            // Verifica se o método AdicionarPedido foi chamado corretamente
            _pedidoRepositoryMock.Verify(repo => repo.AdicionarPedido(It.IsAny<Pedido>()), Times.Once);
        }
    }
}
