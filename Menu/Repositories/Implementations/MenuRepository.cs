using Menu.Models;
using Menu.Repositories.Interfaces;

namespace Menu.Repositories.Implementations
{
    public class MenuRepository : IMenuRepository
    {
        private static List<MenuItem> _menuItems =
        [
            new() { Id = 1, Nome = "Pizza", Preco = 20.00m },
            new () { Id = 2, Nome = "Hamburguer", Preco = 15.00m },
            new (){ Id = 3, Nome = "Salada", Preco = 10.00m }
        ];

        public IEnumerable<MenuItem> GetAllMenuItems()
        {
            return _menuItems;
        }

        public MenuItem GetMenuItemById(int id)
        {
            return _menuItems.FirstOrDefault(item => item.Id == id)!;
        }
    }
}
