using Microsoft.AspNetCore.Mvc;

namespace HW_18.Controllers
{
    public class Product : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
