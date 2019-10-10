using ChatWithMe.Web.Models.Auth;
using Microsoft.AspNetCore.Mvc;

namespace ChatWithMe.Web.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public string SignIn(SignInModel model)
        {
            return "abc";
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult SignOut()
        {
            return Ok();
        }
    }
}
