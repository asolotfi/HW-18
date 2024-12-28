using HW_18.Domain.Contract.Service;
using Microsoft.AspNetCore.Mvc;

namespace HW_18.Controllers
{
    public class UserController : Controller
    {
        private readonly IAuthenticationService _AuthenticationService;

        public UserController(IAuthenticationService authService)
        {
            _AuthenticationService = authService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(string userName, string password)
        {
            var result = _AuthenticationService.Login(userName, password);
            if (result)
            {
                return RedirectToAction("IndexP", "Product");
            }
            else
            {
                TempData["ErrorMessage"] = "ورود به سیستم ناموفق بود";
                return View("Index");
            }
        }

        [HttpPost]
        public IActionResult Register(string userName, string password)
        {

            var result = _AuthenticationService.Register(userName, password);
            if (result)
            {
                return RedirectToAction("IndexP", "Product");
            }
            else
            {
                TempData["ErrorMessage"] = "ثبت نام ناموفق بود";
                return View("SignUp");
            }
        }
    }

}
