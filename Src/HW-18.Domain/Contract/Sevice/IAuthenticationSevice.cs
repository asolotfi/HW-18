namespace HW_18.Domain.Contract.Service
{
    public interface IAuthenticationService
    {
        bool Login(string userName, string password);
        bool Register(string userName, string password);
    }
}

