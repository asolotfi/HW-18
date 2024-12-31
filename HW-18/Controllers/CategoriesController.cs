using HW_18.Domain.Contract.Sevice;
using HW_18.Domain.Entites;
using HW_18.Infrastructure.DB;
using Microsoft.AspNetCore.Mvc;

namespace HW_18.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ICategoryService _categoryService;
        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult IndexC()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }
        [HttpGet]
        public IActionResult CreateCategories(string name)
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(string name)
        {
            var result = _categoryService.AddCategory(name);
            if (result)
            {
                return RedirectToAction("IndexC", "Categories");
            }
            else
            {
                TempData["ErrorMessage"] = "ثبت ناموفق بود.";
                return View("IndexC");
            }
        }
    }

}
