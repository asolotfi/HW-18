using HW_18.Infrastructure.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HW_18.Controllers
{
    public class productController : Controller
    {
        private readonly IProductService _productService;

        private readonly AppDbContext _context;

        public productController(AppDbContext context)
        {
            _context = context;
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
        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.Include(p => p.Category).ToListAsync();
            return View(products);
        }

        // Create: Display create form
        public IActionResult Create()
        {
            ViewData["Categories"] = _context.Products.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Categories"] = _context.Products.ToList();
            return View(product);
        }

        // Update: Display update form
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            ViewData["Categories"] = _context.Products.ToList();
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Product product)
        {
            //if (id != product.id)
            //{
            //    return NotFound();
            //}

            if (ModelState.IsValid)
            {
                _context.Update(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Categories"] = _context.Products.ToList();
            return View(product);
        }

        // Delete: Display delete confirmation
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
