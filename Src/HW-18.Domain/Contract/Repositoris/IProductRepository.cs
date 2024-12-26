using HW_18.Domain.Entites;

namespace HW_18.Domain.Contract.Repositoris
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        bool AddProduct(Product product);
        bool DeleteProduct(Product product);
        bool EditProduct(Product product);
        bool GetProduct(Product product);
        bool GetAllProduct();
    }
}
