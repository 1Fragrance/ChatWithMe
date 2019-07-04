namespace ChatWithMe.Storage.Entities
{
    /// <summary>
    /// User entity
    /// </summary>
    public class UserEntity : EntityBase
    {
        /// <summary>
        /// Entity identificator
        /// </summary>
        public override int Id { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; set; }
    }
}
