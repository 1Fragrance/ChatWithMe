using ChatWithMe.Storage.Abstractions;
using ChatWithMe.Storage.Entities;

namespace ChatWithMe.Storage.Repositories
{
    /// <summary>
    /// User repository
    /// </summary>
    public class UserRepository : RepositoryBase<UserEntity>
    {
        public UserRepository(DatabaseContext dbContext) : base(dbContext.Users, dbContext)
        {
        }
    }
}
