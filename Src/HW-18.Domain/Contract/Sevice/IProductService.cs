using HW_18.Domain.Entites;

namespace HW_18.Controllers
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts(); // متد برای دریافت همه محصولات
        bool AddProduct(Product product);
        bool DeleteProduct(Product product);
        bool EditProduct(Product product);
        bool GetProduct(Product product);
        bool GetAllProduct();


    }
}