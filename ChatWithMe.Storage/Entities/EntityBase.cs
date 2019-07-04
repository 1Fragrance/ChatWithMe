using System;

namespace ChatWithMe.Storage.Entities
{
    /// <summary>
    /// Base entity class
    /// </summary>
    public abstract class EntityBase
    {
        /// <summary>
        /// Entity identificator
        /// </summary>
        public abstract int Id { get; set; }

        /// <summary>
        /// Entity create date
        /// </summary>
        public DateTime CreateDate { get; set; }
        
        /// <summary>
        /// Entity update date
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}