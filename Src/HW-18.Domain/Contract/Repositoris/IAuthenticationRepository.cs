namespace HW_18.Domain.Contract.Repositoris
{
    public interface IAuthenticationRepository
    {
        bool Login(string userName, string password);
        bool Register(string userName, string password);
    }
}
