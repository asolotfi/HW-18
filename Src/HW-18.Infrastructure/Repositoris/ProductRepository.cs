using HW_18.Domain.Contract.Repositoris;
using HW_18.Domain.Entites;
using HW_18.Infrastructure.DB;
using HW_18.Infrastructure.Service;
using Microsoft.EntityFrameworkCore;

namespace HW_18.Infrastructure.Repositoris
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext = new AppDbContext();
        private readonly AuthenticationService _AuthenticationService;
        public bool AddProduct(string name, int price, int categoryId)
        {
            try
            {
                if (name == null || price <= 0 || categoryId == null)
                {
                    return false;
                }
                var productNew = new Product
                {
                    Name = name,
                    Price = price,
                    CategoryId = categoryId,
                };
                _appDbContext.Products.Add(productNew);
                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new ApplicationException("خطا در زمان ثبت کالا", ex);
            }
        }

        public bool DeleteProduct(int id)
        {
            try
            {
                var result = _appDbContext.Products.FirstOrDefault(x => x.Id == id);
                if (result!=null)
                {
                    _appDbContext.Remove(result);
                    _appDbContext.SaveChanges();
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new ApplicationException("خطا در زمان حذف کالا", ex);
            }
        }
        public bool EditProduct(int id,string name, int price, int categoryId)
        {
            //در صورتی که خالی بود قبلی بخونه
            try
            {
                var result = _appDbContext.Products.FirstOrDefault(x => x.Id == id);
                if (result != null)
                {
                    result.Name = name;
                    result.Price = price;
                    result.CategoryId = categoryId;
                    _appDbContext.SaveChanges();
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new ApplicationException("خطا در زمان ویرایش کالا", ex);
            }
        }

        public List<Product> GetAllProduct()
        {
            return _appDbContext.Products.Include(p => p.Category).ToList();
        }
        public Product GetProduct(int id)
        {
            return _appDbContext.Products.FirstOrDefault(x => x.Id == id);
        }
    }
}
