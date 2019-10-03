using MongoDB.Bson.Serialization.Attributes;
using System;
using MongoDB.Bson;

namespace ChatWithMe.Storage.Abstractions
{
    /// <summary>
    /// Base entity class
    /// </summary>
    public abstract class EntityBase
    {
        /// <summary>
        /// Entity identificator
        /// </summary>
        [BsonId]
        public ObjectId ObjectId { get; set; }

        /// <summary>
        /// Entity identificator
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Entity create date
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Entity update date
        /// </summary>
        [BsonDateTimeOptions]
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}