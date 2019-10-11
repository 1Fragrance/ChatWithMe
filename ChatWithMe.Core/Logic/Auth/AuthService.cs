using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatWithMe.AuthStorage;
using ChatWithMe.AuthStorage.Entities;
using ChatWithMe.Common.Enums;
using ChatWithMe.Common.Infrastructure;
using ChatWithMe.Core.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace ChatWithMe.Core.Logic.Auth
{
    public class AuthService : IAuthService
    {
        private readonly AuthDataSource _authDatabase;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthService(AuthDataSource authDatabase, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _authDatabase = authDatabase;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public ExecutionResult SignUp(string password, string email, string username)
        {
            var user = new ApplicationUser
            {
                UserName = username,
                Email = email,
                Status = UserStatus.Active
            };

            var result = _userManager.CreateAsync(user, password).GetAwaiter().GetResult();
            if (result.Succeeded)
            {
                _signInManager.SignInAsync(user, false).GetAwaiter().GetResult();
            }
            else
            {
                var errorsList = result.Errors.Select(error => new ErrorInfo(error.Description)).ToList();
                return new ExecutionResult(errorsList);
            }

            return new ExecutionResult();
        }

        public ExecutionResult SignOut()
        {
            throw new System.NotImplementedException();
        }

        public ExecutionResult SignIn(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public ExecutionResult ChangePassword(string oldPassword, string newPassword)
        {
            throw new System.NotImplementedException();
        }
    }
}
