using HW_18.Domain.Contract.Sevice;
using HW_18.Domain.Entites;
using HW_18.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW_18.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var category = new Category { Name = model.Name };
                _categoryService.AddCategory(category);
                return RedirectToAction("Index", "Categories");
            }
            return View(model);
        }
    }

}
