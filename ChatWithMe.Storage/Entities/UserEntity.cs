using ChatWithMe.Common.Enums;
using ChatWithMe.Storage.Abstractions;

namespace ChatWithMe.Storage.Entities
{
    public class UserEntity : EntityBase
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public UserStatus Status { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }
    }
}
