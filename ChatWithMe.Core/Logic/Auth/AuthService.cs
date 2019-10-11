using ChatWithMe.Core.Interfaces;
using ChatWithMe.DataStorage;

namespace ChatWithMe.Core.Logic.Auth
{
    public class AuthService : IAuthService
    {
        private readonly DataSource _database;

        public AuthService(DataSource database)
        {
            _database = database;
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
