using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Регистрация прошла успешно!";
                return View("Success");
            }

            return View(model);
        }

        public JsonResult CheckUsername(string username)
        {
            bool exists = false; 
            if (exists)
            {
                return Json(false);
            }
            return Json(true);
        }
    }
}
