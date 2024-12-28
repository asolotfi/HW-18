using HW_18.Controllers;
using HW_18.Domain.Contract.Repositoris;
using HW_18.Domain.Entites;
using HW_18.Infrastructure.Repositoris;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HW_18.Infrastructure.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _ProductRepository;

        public ProductService(IProductRepository productRepository)
        {
            _ProductRepository = productRepository;
        }
        public bool AddProduct(string name, int price, int categoryId)
        {
            var result = _ProductRepository.AddProduct(name,  price,categoryId);
            return result;
        }
        public bool DeleteProduct(int id)
        {
            var result = _ProductRepository.DeleteProduct(id);
            return result;
        }
        public bool EditProduct(string name, int price, int categoryId)
        {
            var result = _ProductRepository.EditProduct(name,  price,categoryId);
            return result;
        }
        public List<Product>  GetAllProduct()
        {
            return  _ProductRepository.GetAllProduct();
        }
        public Product GetProduct(int id)
        {
            return _ProductRepository.GetProduct(id);
        }    
    }
}
