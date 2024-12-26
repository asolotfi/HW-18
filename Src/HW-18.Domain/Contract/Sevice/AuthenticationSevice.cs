using HW_18.Domain.Contract.Authentication;

namespace HW_18.Domain.Contract.Service
{
    public class AuthenticationService
    {
        private readonly IAuthentication _authentication;

        public AuthenticationService(IAuthentication authentication)
        {
            _authentication = authentication;
        }

        public bool Login(string cardNumber, string password)
        {
            var result = _authentication.Login(cardNumber, password);
            return result;
        }
    }
}

