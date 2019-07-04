using ChatWithMe.Storage.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChatWithMe.Storage.Repositories
{
    /// <summary>
    /// User repository
    /// </summary>
    public class UserRepository : RepositoryBase<UserEntity>
    {
        public UserRepository(DbContext dbContext) : base(dbContext.UserSet, dbContext)
        {
        }
    }
}
