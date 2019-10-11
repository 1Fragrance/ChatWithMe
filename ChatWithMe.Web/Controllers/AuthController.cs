using ChatWithMe.Core.Interfaces;
using ChatWithMe.Web.Models.Auth;
using Microsoft.AspNetCore.Mvc;

namespace ChatWithMe.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }


        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public string SignIn(SignInViewModel model)
        {
            return "abc";
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _authService.SignUp(model.Password, model.Email, model.Username);

                if (result.IsSuccess)
                {
                    RedirectToAction("SignIn", "Auth");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Key, error.Description);
                    }
                }
            }

            return View(model); ;
        }

        [HttpPost]
        public IActionResult SignOut()
        {
            return Ok();
        }
    }
}
