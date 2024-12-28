namespace HW_18.Infrastructure.Service
{
    public class UserService : IAuthentication
    {
        //public class UserService : IUserService
        //{
        //private readonly AppDbContext _appDbContext;
        //public UserService()
        //{
        //    _appDbContext = new AppDbContext();
        //}

        //public User GetUser(string userName)
        //{
        //    throw new NotImplementedException();
        //}


        //  public User GetUser(string cardNumber)
        //  {
        ////      Card card = _appDbContext.Cards
        ////.Include(c => c.User)
        ////.ThenInclude(u => u.cards) // بارگذاری کارت‌های کاربر نیز
        ////.Where(c => c.CardNumber == cardNumber)
        ////.FirstOrDefault();
        ////      return card.User;

        //  }
        //}
        public bool Login(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
