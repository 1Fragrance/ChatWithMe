namespace ChatWithMe.Storage.Entities
{
    /// <summary>
    /// Message entity
    /// </summary>
    public class MessageEntity : EntityBase
    {
        /// <summary>
        /// Entity identificator
        /// </summary>
        public override int Id { get; set; }

        /// <summary>
        /// Message content
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Sender identificator
        /// </summary>
        public int SenderId { get; set; }

        /// <summary>
        /// Sender entity
        /// </summary>
        public UserEntity Sender { get; set; }

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
