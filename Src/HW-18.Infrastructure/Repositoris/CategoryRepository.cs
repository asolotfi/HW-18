using HW_18.Domain.Contract.Repositoris;
using HW_18.Domain.Entites;
using HW_18.Infrastructure.DB;
using System.Diagnostics;

namespace HW_18.Infrastructure.Repositoris
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool AddCategory(string name)
        {
            try
            {
                if (name == null)
                {
                    return false;
                }
                var category = new Category
                {
                    Name = name,
                };
                _context.Categories.Add(category);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new ApplicationException("خطا در زمان ثبت ", ex);
            }         
        }
        public bool DeleteCategory(int id)
        {
            try
            {
                var result = _context.Products.Any(x => x.Id == id);
                if (result)
                {
                    _context.Remove(id);
                    _context.SaveChanges();
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

        public bool EditCategory(string name)
        {
            //در صورتی که خالی بود قبلی بخونه
            try
            {
                var result = _context.Categories.Any(x => x.Name == name);
                if (result)
                {
                    var category = new Category
                    {
                        Name = name,
                    };
                    _context.SaveChanges();
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

        public List< Category> GetAllCategory()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.Id == id);
        }
    }
}
