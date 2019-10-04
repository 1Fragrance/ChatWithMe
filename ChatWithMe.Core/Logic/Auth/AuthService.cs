using System.Security.Cryptography.X509Certificates;
using ChatWithMe.Common;
using ChatWithMe.Common.Enums;
using ChatWithMe.Core.Interfaces;
using ChatWithMe.Storage;
using ChatWithMe.Storage.Entities;

namespace ChatWithMe.Core.Logic.Auth
{
    public class AuthService : IAuthService
    {
        private readonly DataSource _database;

        public AuthService(DataSource database)
        {
            _database = database;
        }

        public async void Register(string username, string email, string password)
        {
            await _database.Users.Save(new UserEntity
            {
                Email = "test",
                Password = "testpswrd",
                Description = "test",
                Status = UserStatus.Active,
                Username = "username"
            });
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
