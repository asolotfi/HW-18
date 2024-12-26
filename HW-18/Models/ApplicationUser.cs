namespace HW_18.Models
{
    using Microsoft.AspNetCore.Identity;

    namespace YourProjectNamespace.Models // جایگزین با فضای نام واقعی پروژه خود کنید
    {
        public class ApplicationUser : IdentityUser
        {
            // شما می‌توانید فیلدهای اضافی را برای کاربر تعریف کنید
            // به عنوان مثال:
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }

}
