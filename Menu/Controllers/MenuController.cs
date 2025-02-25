using Menu.Services;
using Microsoft.AspNetCore.Mvc;

namespace Menu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController(MenuService menuService) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMenuItems()
        {
            var menu = menuService.GetMenuItems();
            return Ok(menu);
        }
    }

}
