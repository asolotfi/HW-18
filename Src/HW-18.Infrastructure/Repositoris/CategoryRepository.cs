using HW_18.Domain.Contract.Repositoris;
using HW_18.Domain.Entites;
using HW_18.Infrastructure.DB;

namespace HW_18.Infrastructure.Repositoris
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public bool DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public bool EditCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public bool Get(Category category)
        {
            throw new NotImplementedException();
        }

        public bool GetAllCategory()
        {
            throw new NotImplementedException();
        }

        public bool GetCategory(Category category)
        {
            throw new NotImplementedException();
        }

        bool ICategoryRepository.AddCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
