using ChatWithMe.Common.Enums;
using Microsoft.AspNetCore.Identity;

namespace ChatWithMe.AuthStorage.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public UserStatus Status { get; set; }
    }
}
