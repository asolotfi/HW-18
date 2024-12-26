using HW_18.Domain.Entites;

namespace HW_18.Domain.Contract.Repositoris
{
    public interface IUserRepository
    {
        User GetUser(string userName);
    }
}

