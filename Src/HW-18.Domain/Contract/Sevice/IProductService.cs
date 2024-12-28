using HW_18.Domain.Entites;

namespace HW_18.Controllers
{
    public interface IProductService
    {
        bool AddProduct(string name, int price, int categoryId);
        bool DeleteProduct(int id);
        bool EditProduct(string name, int price, int categoryId);
        Product GetProduct(int id);
        List<Product> GetAllProduct();


    }
}