using HW_18.Domain.Entites;

namespace HW_18.Domain.Contract.Repositoris
{
    public interface ICategoryRepository
    {
        bool AddCategory(Category category);
        bool DeleteCategory(Category category);
        bool EditCategory(Category category);
        bool GetCategory(Category category);
        bool GetAllCategory();
        bool Get(Category category);
    }

}
