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

        public bool AddCategory(string name)
        {
            return _categoryRepository.AddCategory(name);
        }

        public bool DeleteCategory(int id)
        {
            var result = _categoryRepository.DeleteCategory(id);
            return result;
        }
        public bool EditCategory(string name)
        {
            var result = _categoryRepository.EditCategory(name);
            return result;
        }
        public Category GetCategory(int id)
        {
            return _categoryRepository.GetCategory(id);
        }
        public List<Category> GetAllCategory()
        {
            return _categoryRepository.GetAllCategory();
        }
    }
}
