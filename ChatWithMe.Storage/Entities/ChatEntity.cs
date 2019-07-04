namespace ChatWithMe.Storage.Entities
{
    /// <summary>
    /// Chat entity
    /// </summary>
    public class ChatEntity : EntityBase 
    {
        /// <summary>
        /// Entity identificator
        /// </summary>
        public override int Id { get; set; }

        /// <summary>
        /// Chat name
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Admin id 
        /// </summary>
        public int AdminUserId { get; set; }

        /// <summary>
        /// Admin entity
        /// </summary>
        public virtual UserEntity AdminUser { get; set; }
    }
}
