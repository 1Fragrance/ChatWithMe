using System;
using System.Collections.Generic;
using System.Text;

namespace ChatWithMe.Core.Interfaces
{
    public interface IAuthService
    {
        void Register(string username, string email, string password);

        void Logout();

        void Login(string username, string password);

        void ChangePassword(string oldPassword, string newPassword);
    }
}
