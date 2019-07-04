using ChatWithMe.Storage.Entities;

namespace ChatWithMe.Storage.Repositories
{
    /// <summary>
    /// Chat repostiory
    /// </summary>
    public class ChatRepository : RepositoryBase<ChatEntity>
    {
        public ChatRepository(DbContext dbContext) : base(dbContext.ChatSet, dbContext)
        {
        }
    }
}
