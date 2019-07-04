using ChatWithMe.Storage.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChatWithMe.Storage.Repositories
{
    /// <summary>
    /// Message repository
    /// </summary>
    public class MessageRepository : RepositoryBase<MessageEntity>
    {
        public MessageRepository(DbContext dbContext) : base(dbContext.MessageSet, dbContext)
        {
        }
    }
}
