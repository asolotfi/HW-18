namespace HW_18.Domain.Contract.Authentication
{
    public interface IAuthentication
    {
        bool Login(string userName, string password);
    }
}
