using ChatWithMe.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Microsoft.Extensions.Options;

namespace ChatWithMe.Storage
{
    /// <summary>
    /// Represent database context
    /// </summary>
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected internal virtual DbSet<ChatEntity> ChatSet { get; set; }
        protected internal virtual DbSet<UserEntity> UserSet { get; set; }
        protected internal virtual DbSet<MessageEntity> MessageSet { get; set; }

        public DbContext(DbContextOptions<DbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }
            

            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries().Where(x => (x.State == EntityState.Added || x.State == EntityState.Modified));

            var currentTime = DateTime.UtcNow;

            foreach (var entry in modifiedEntries)
            {
                if (entry.Entity is EntityBase entity)
                {
                    if (entry.State == EntityState.Added)
                    {
                        entity.CreateDate = currentTime;
                    }

                    entity.UpdateDate = currentTime;
                }
            }

            return base.SaveChanges();
        }
    }
}
