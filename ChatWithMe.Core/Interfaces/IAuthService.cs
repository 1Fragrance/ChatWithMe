using ChatWithMe.Common.Infrastructure;

namespace ChatWithMe.Core.Interfaces
{
    public interface IAuthService
    {
        ExecutionResult SignUp(string password, string email, string username);

        ExecutionResult SignOut();

        ExecutionResult SignIn(string username, string password);

        ExecutionResult ChangePassword(string oldPassword, string newPassword);
    }
}
