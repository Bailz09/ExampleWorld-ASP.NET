using Microsoft.AspNetCore.Mvc;

namespace ExampleWorld
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Dictionary<string, object>> data = new()
            {
                new() { {"Id", 1}, { "Name", "Fruits and Veg"}  },
                new() { {"Id", 2}, { "Name", "Meats"}  },
                new() { {"Id", 3}, { "Name", "Sweet and Treats"}  },
            };

            return View(data);
        }
    }

}
