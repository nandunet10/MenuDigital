using Menu.Models;
using Menu.Repositories.Interfaces;
using Menu.Services;
using Moq;

namespace MenuDigital.Tests.Tests
{
    public class MenuServiceTests
    {
        private readonly MenuService _menuService;
        private readonly Mock<IMenuRepository> _menuRepositoryMock;

        public MenuServiceTests()
        {
            _menuRepositoryMock = new Mock<IMenuRepository>();
            _menuService = new MenuService(_menuRepositoryMock.Object);
        }

        [Fact]
        public void GetMenuItems_ShouldReturnMenuItems()
        {
            // Arrange
            var menuItems = new List<MenuItem>
            {
                new() { Id = 1, Nome = "Pizza", Preco = 20.00m },
                new() { Id = 2, Nome = "Hamburguer", Preco = 15.00m }
            };
            _menuRepositoryMock.Setup(repo => repo.GetAllMenuItems()).Returns(menuItems);

            // Act
            var result = _menuService.GetMenuItems();

            // Assert
            Assert.Equal(2, result.Count());
        }
    }

}
