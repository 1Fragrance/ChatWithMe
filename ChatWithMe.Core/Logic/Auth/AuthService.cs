using ChatWithMe.AuthStorage;
using ChatWithMe.Core.Interfaces;
using ChatWithMe.DataStorage;

namespace ChatWithMe.Core.Logic.Auth
{
    public class AuthService : IAuthService
    {
        private readonly AuthDataSource _authDatabase;

        public AuthService(AuthDataSource authDatabase)
        {
            _authDatabase = authDatabase;
        }

        public void Register(string username, string email, string password)
        {
            throw new System.NotImplementedException();
        }

        public void Logout()
        {
            throw new System.NotImplementedException();
        }

        public void Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public void ChangePassword(string oldPassword, string newPassword)
        {
            throw new System.NotImplementedException();
        }
    }
}
