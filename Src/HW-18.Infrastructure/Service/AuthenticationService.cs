using HW_18.Domain.Contract.Repositoris;
using HW_18.Domain.Contract.Service;


namespace HW_18.Infrastructure.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthenticationRepository _authenticationRepository;

        public AuthenticationService(IAuthenticationRepository authenticationRepository)
        {
            _authenticationRepository = authenticationRepository;
        }
   
            public bool Login(string userName, string password)
        {
            var result = _authenticationRepository.Login(userName, password);
            return result;
        }
        public bool Register(string userName, string password)
        {
            var result = _authenticationRepository.Register(userName, password);
            return result;
        }
    }
}
