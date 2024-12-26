using HW_18.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_18.Domain.Contract.Sevice
{
    public interface ICategoryService
    {
        bool AddCategory(Category category);
        bool DeleteCategory(Category category);
        bool EditCategory(Category category);
        bool GetCategory(Category category);
        bool GetAllCategory();
        bool Get(Category category);
    }
}
