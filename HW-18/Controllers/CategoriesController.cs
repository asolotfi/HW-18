using HW_18.Domain.Contract.Sevice;
using HW_18.Domain.Entites;
using HW_18.Infrastructure.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> IndexC()
        {
            var categories = await _context.Categories.ToListAsync();
            return View(categories);
        }
        [HttpPost]
        public IActionResult AddCategory(string name)
        {
            var result = _categoryService.AddCategory(name);
            if (result)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["ErrorMessage"] = "ثبت ناموفق بود.";
                return View("Index");
            }
        }
        [HttpPost]
        public IActionResult Edit(string name)
        {
            var result = _categoryService.EditCategory(name);
            if (result)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["ErrorMessage"] = "ویرایش ناموفق بود.";
                return View("Index");
            }
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var result = _categoryService.DeleteCategory(id);
            if (result)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["ErrorMessage"] = "حذف ناموفق بود.";
                return View("Index");
            }
        }
        [HttpGet]
        public Category GetCategory(int id)
        {
            var result = _categoryService.GetCategory(id);

            return result;
        }
        [HttpGet]
        public List<Category> GetAllCategory()
        {
            return _categoryService.GetAllCategory();
        }

    }

}
