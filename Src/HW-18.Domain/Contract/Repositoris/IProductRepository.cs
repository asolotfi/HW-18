using HW_18.Domain.Entites;

namespace HW_18.Domain.Contract.Repositoris
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
}
