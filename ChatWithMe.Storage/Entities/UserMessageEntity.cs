namespace ChatWithMe.Storage.Entities
{
    /// <summary>
    /// Entity which contains read status of message
    /// </summary>
    public class UserMessageEntity : EntityBase
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
        /// Message identificator
        /// </summary>
        public int MessageId { get; set; }

        /// <summary>
        /// Message Entity
        /// </summary>
        public MessageEntity Message { get; set; }

        /// <summary>
        /// Message read flag
        /// </summary>
        public bool IsReaded { get; set; }
    }
}
