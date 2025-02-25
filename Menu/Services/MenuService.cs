using Menu.Models;
using Menu.Repositories.Interfaces;

namespace Menu.Services
{
    public class MenuService(IMenuRepository menuRepository)
    {
        public IEnumerable<MenuItem> GetMenuItems()
        {
            return menuRepository.GetAllMenuItems();
        }
    }

}
