using ChatWithMe.Storage.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChatWithMe.Storage.Repositories
{
    /// <summary>
    /// Repository base class
    /// </summary>
    public abstract class RepositoryBase<T> where T : EntityBase
    {
        protected DbSet<T> DbSet { get; }
        protected DbContext DbContext { get; }

        protected RepositoryBase(DbSet<T> dbSet, DbContext dbContext)
        {
            DbSet = dbSet;
            DbContext = dbContext;
        }

        public EntityBase Get(int id)
        {
            return DbSet.Find(id);
        }


        public void Delete(int id)
        {
            var entity = DbSet.Find(id);

            if (entity == null)
            {
                return;
            }

            DbSet.Remove(entity);
        }

        public T Save(T entity)
        {
            var result = entity.Id > 0 ? DbSet.Update(entity) : DbSet.Add(entity);

            DbContext.SaveChanges();

            return result.Entity;
        }
    }
}