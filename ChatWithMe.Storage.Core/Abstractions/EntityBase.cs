using System;

namespace ChatWithMe.Storage.Abstractions
{
    /// <summary>
    /// Base entity class
    /// </summary>
    public abstract class EntityBase
    {
        /// <summary>
        /// Entity create date
        /// </summary>
        public virtual DateTime CreateDate { get; set; }

        /// <summary>
        /// Entity update date
        /// </summary>
        public virtual DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}