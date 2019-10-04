using System.Runtime.Serialization;
using MongoDB.Bson;

namespace ChatWithMe.Common.Items
{
    /// <summary>
    /// Base items class
    /// </summary>
    public abstract class ItemBase
    {
        /// <summary>
        /// Item identificator
        /// </summary>
        public ObjectId Id { get; set; }
    }
}