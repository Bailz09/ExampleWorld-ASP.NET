using System.Reflection.Emit;
using Microsoft.AspNetCore.Mvc;
using ExampleWorld.Models;

namespace ExampleWorld.Components.ViewComponents
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var MenuItems = new List<MenuItem>
            {
                new MenuItem { Controller = "Home", Action = "Index", Label = "Home" },
                new MenuItem { Controller = "Departments", Action = "Index", Label = "Departments" },
                new MenuItem { Controller = "Products", Action = "Index", Label = "Products" },
                new MenuItem { Controller = "Carts", Action = "Index", Label = "View My Cart" },
                new MenuItem { Controller = "Home", Action = "Privacy", Label = "Privacy" },
            };
            
            return View(MenuItems);
            
        }
    }
}