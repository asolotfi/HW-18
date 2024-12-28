using HW_18.Domain.Entites;

namespace HW_18.Domain.Contract.Sevice
{
    public interface ICategoryService
    {
        bool AddCategory(string name);
        bool DeleteCategory(int id );
        bool EditCategory(string name);
        Category GetCategory(int id);
        List<Category> GetAllCategory();
    }
}
