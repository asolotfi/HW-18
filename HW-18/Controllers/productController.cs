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
            _productService = productService; 
        }
        [HttpGet]
        public IActionResult IndexP()
        {
            var products =  _context.Products.Include(p => p.Category).ToList();
            return View(products);
        }
        [HttpGet]
        public IActionResult createProduct(string name, int price, int categoryId)
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(string name, int price, int categoryId)
        {
            var result = _productService.AddProduct(name, price, categoryId);
            if (result)
            {
                TempData["ErrorMessage"] = "ثبت موفق بود.";
                return RedirectToAction("IndexP", "Product");
            }
            else
            {
                TempData["ErrorMessage"] = "ثبت ناموفق بود.";
                return View("IndexP");
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _productService.GetProduct(id);
            if (result!=null)
            {
                return View("EditProduct","Product");
            }
            else
            {
                TempData["ErrorMessage"] = "جستجو ناموفق بود.";
                return View("IndexP","Product");
            }
        }
        [HttpPost]
        public IActionResult EditProduct(int id,string name, int price, int categoryId)
        {
            var resultG = _productService.GetProduct(id);
            var result = _productService.EditProduct(id,name, price, categoryId);
            if (result && resultG!=null)
            {
                TempData["ErrorMessage"] = " موفق بود.";
                return RedirectToAction("IndexP", "Product");
            }
            else
            {
                TempData["ErrorMessage"] = "ویرایش ناموفق بود.";
                return View("IndexP", "Product");
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = _productService.DeleteProduct(id);
            if (result)
            {
                TempData["ErrorMessage"] = " حذف موفق بود.";
                return RedirectToAction("IndexP", "Product");
            }
            else
            {
                TempData["ErrorMessage"] = "حذف ناموفق بود.";
                return View("IndexP", "Product");
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
