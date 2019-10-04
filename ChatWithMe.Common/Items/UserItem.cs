using ChatWithMe.Common.Abstractions;

namespace ChatWithMe.Common.Items
{
    public class UserItem : ItemBase
    {
        public string Username { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }
    }
}
