using HW_18.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_18.Domain.Contract.Repositoris
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        // سایر متدها
    }

}
