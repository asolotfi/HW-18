using HW_18.Domain.Contract.Repositoris;
using HW_18.Domain.Contract.Sevice;
using HW_18.Domain.Entites;

namespace HW_18.Infrastructure.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void AddCategory(Category category)
        {
            _categoryRepository.AddCategory(category);
        }
    }
}
