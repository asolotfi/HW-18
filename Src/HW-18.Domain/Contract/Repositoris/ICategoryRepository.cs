using HW_18.Domain.Entites;

namespace HW_18.Domain.Contract.Repositoris
{
    public interface ICategoryRepository
    {
        bool AddCategory(string name);
        bool DeleteCategory(int id);
        bool EditCategory(string name);
        Category GetCategory(int id);
        List<Category> GetAllCategory();
    }

}
