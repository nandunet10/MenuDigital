using Menu.Models;

namespace Menu.Repositories.Interfaces
{
    public interface IMenuRepository
    {
        IEnumerable<MenuItem> GetAllMenuItems();
        MenuItem GetMenuItemById(int id);
    }
}
