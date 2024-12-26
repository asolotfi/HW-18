using Microsoft.AspNetCore.Mvc;

namespace HW_18.Controllers
{
    public class productController : Controller
    {
        private readonly IProductService _productService;

        public productController(IProductService productService)
        {
            _productService = productService;
        }
        //public ActionResult Index()
        //{
        //    var products = _productService.GetAllProduct();
        //    return View(products);
        //}

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    var db = new AppDbContext();
        //    List<Product> products = db.products.ToList();
        //    return View(products);
        //}

        //[HttpGet]
        //public IActionResult create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult createProduct(string name, int price, int category)
        //{
        //    var db = new AppDbContext();
        //    db.products.Add(new Product
        //    {
        //        Name = name,
        //        Price = price,
        //        CategoryId = category
        //    }
        //    );
        //    db.SaveChanges();
        //    return RedirectToAction("Index");

        //}
    }
}
