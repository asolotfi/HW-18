using HW_18.Domain.Contract.Repositoris;
using HW_18.Domain.Entites;
using HW_18.Infrastructure.DB;
using HW_18.Infrastructure.Service;

namespace HW_18.Infrastructure.Repositoris
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly AuthenticationService _AuthenticationService;
        public AuthenticationRepository()
        {
            _appDbContext = new AppDbContext();
        }
        public bool Login(string userName, string password)
        {
            try
            {
                if (_appDbContext.users.Any(x => x.UserName == userName && x.Password == password))
                {
                    InMemoryDB.OnlineUser = GetUser(userName);
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                throw new NotImplementedException("User not Found");
            }
        }
        public User GetUser(string userName)
        {
            User user = _appDbContext.users
           .Where(c => c.UserName == userName)
           .FirstOrDefault();
            return user;

        }

        public bool Register(string userName, string password)
        {
            try
            {    
                if(userName==null || password == null)
                {
                    return false;
                }
                else if (_appDbContext.users.Any(x => x.UserName == userName && x.Password == password))
                {
                    return false;
                }            
                var user = new User()
                {
                    UserName = userName,
                    Password = password 
                };
                _appDbContext.users.Add(user);
                _appDbContext.SaveChanges();

                return true; 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new ApplicationException("خطا در زمان ثبت‌نام کاربر", ex);
            }
        }

    }
}
