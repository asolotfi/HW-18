using HW_18.Domain.Entites;

namespace HW_18.Controllers
{
    public interface IProductService
    {
            IEnumerable<Product> GetAllProducts(); // متد برای دریافت همه محصولات
            Product GetProductById(int id); // متد برای دریافت محصول بر اساس شناسه
                                            // سایر متدهای مورد نیاز می‌توانند اینجا اضافه شوند
  

    }
}