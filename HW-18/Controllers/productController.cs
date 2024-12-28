using HW_18.Domain.Entites;
using HW_18.Infrastructure.DB;
using HW_18.Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HW_18.Controllers
{
    public class productController : Controller
    {
  
        private readonly IProductService _productService;
        private readonly AppDbContext _context;

        public productController(AppDbContext context , IProductService productService)
        {
            _context = context;
            _productService = productService; // اطمینان از این مقداردهی
        }
        [HttpGet]
        public IActionResult IndexP()
        {
            var products = _productService.GetAllProduct(); // فراخوانی لیست محصولات
            return View(products);
        }
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(string name, int price, int categoryId)
        {
            var result = _productService.AddProduct(name, price, categoryId);
            if (result)
            {
                return RedirectToAction("IndexP", "Product");
            }
            else
            {
                TempData["ErrorMessage"] = "ثبت ناموفق بود.";
                return View("Index");
            }
        }
        [HttpPost]
        public IActionResult Edit(string name, int price, int categoryId)
        {
            var result = _productService.EditProduct( name,price,categoryId);
            if (result)
            {
                return RedirectToAction("IndexP", "Product");
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
            var result = _productService.DeleteProduct(id);
            if (result)
            {
                return RedirectToAction("IndexP", "Product");
            }
            else
            {
                TempData["ErrorMessage"] = "حذف ناموفق بود.";
                return View("Index");
            }
        }
        [HttpGet]
        public IActionResult GetProduct(int id)
        {
            var result = _productService.GetProduct(id);
            if (result == null)
            {
                TempData["ErrorMessage"] = "محصولی وجود ندارد.";
                return RedirectToAction("IndexP", "Product");
            }
            else
                return View(result);
        }
        [HttpGet]
        public IActionResult GetAllProduct()
        {
            var result =_productService.GetAllProduct();
            Console.WriteLine($"Number of products retrieved: {result.Count}");
            
            if (result == null || !result.Any())
            {
                TempData["ErrorMessage"] = "محصولی وجود ندارد.";
                return RedirectToAction("IndexP", "Product");
            }
            else
                
                return View(result);
           
        }
    }
}
