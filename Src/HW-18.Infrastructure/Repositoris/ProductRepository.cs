using HW_18.Domain.Contract.Repositoris;
using HW_18.Domain.Entites;

namespace HW_18.Infrastructure.Repositoris
{
    public class ProductRepository : IProductRepository
    {
        //private readonly AppContext _appContext;

        //public ProductRepository(AppContext appContext)
        //{
        //    _appContext = appContext;
        //}

        //public IEnumerable<Product> GetAllProducts()
        //{
        //    return _appContext.Products.ToList();
        //}
        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
