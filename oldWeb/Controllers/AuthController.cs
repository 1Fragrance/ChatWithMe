using ChatWithMe.Common;
using ChatWithMe.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using ChatWithMe.Web.Models.Auth;

namespace ChatWithMe.Web.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        // POST auth/signup
        [HttpPost("sign-up")]
        public ActionResult Register([FromBody] SignUpModel model)
        {
            return null;
            //return new string[] { "value1", "value2" };
        }

        // POST auth/logout
        [HttpPost("logout")]
        public ActionResult Logout()
        {
            return null;
        }

        // POST auth/signin
        [HttpPost("sign-in")]
        public ActionResult Login([FromBody] SignInModel model)
        {
            return null;
        }
    }
}
