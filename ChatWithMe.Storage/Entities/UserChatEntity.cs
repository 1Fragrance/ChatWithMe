namespace ChatWithMe.Storage.Entities
{
    /// <summary>
    /// Entity which linking users with chat
    /// </summary>
    public class UserChatEntity : EntityBase
    {
        /// <summary>
        /// Entity identificator
        /// </summary>
        public override int Id { get; set; }

        /// <summary>
        /// User identificator
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// User entity
        /// </summary>
        public UserEntity User { get; set; }

        /// <summary>
        /// Chat identificator
        /// </summary>
        public int ChatId { get; set; }

        /// <summary>
        /// Chat entity
        /// </summary>
        public ChatEntity Chat { get; set; }
    }
}
