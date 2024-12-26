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
            _context.categories.Add(category);
            _context.SaveChanges();
        }
    }
}
