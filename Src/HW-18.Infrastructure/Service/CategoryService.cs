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

        bool ICategoryService.AddCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
