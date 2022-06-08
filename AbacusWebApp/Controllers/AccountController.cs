using Microsoft.AspNetCore.Mvc;
using AbacusWebApp.Models;

namespace AbacusWebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult LogIn()
        {
            LoginViewModel sessionObj = HttpContext.Session.Get<LoginViewModel>("loginVm");
            if (sessionObj == null)
                return View();
            else
            {
                return RedirectUser(sessionObj);
            }
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Set<LoginViewModel>("loginVm", null);
            return RedirectToAction("Login");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogIn(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                LoginViewModel loginVm = null; //API Call
                if (loginVm != null)
                {
                    HttpContext.Session.Set<LoginViewModel>("loginVm", loginVm);
                    return RedirectUser(loginVm);
                }
            }

            return View(loginViewModel);

        }

        public IActionResult RedirectUser(LoginViewModel loginVm)
        {
            if (loginVm.Role == (int)EnumRoles.Admin)
            {
                return RedirectToAction("Index", "Users");
            }
            else if (loginVm.Role == (int)EnumRoles.teacher)
            {

                return RedirectToAction("Index", "Exams");
            }
            return RedirectToAction("Index", "Students");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
