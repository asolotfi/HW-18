using HW_18.Controllers;
using HW_18.Domain.Contract.Repositoris;
using HW_18.Domain.Entites;

namespace HW_18.Infrastructure.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _ProductRepository;

        public ProductService(IProductRepository productRepository)
        {
            _ProductRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return _ProductRepository.GetAllProducts();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
