using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ChatWithMe.Storage.Abstractions;
using ChatWithMe.Storage.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

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

        public async Task<UserEntity> Save(UserEntity entity)
        {
            if (entity != null)
            {
                await Collection.InsertOneAsync(entity);
            }

            return entity;
        }

        // TODO: Filters & ordering
        public async Task<IList<UserEntity>> GetAll()
        {
            return await Collection.Find(new BsonDocument()).ToListAsync();
        }

        // TODO: -//-
        public async Task<IList<UserEntity>> GetPage(int start, int count)
        {
            return await Collection.Find(new BsonDocument())
                .Skip(start)
                .Limit(count)
                .ToListAsync();
        }

        public async void Delete(ObjectId id)
        {
            var filter = Builders<UserEntity>.Filter.Eq("_id", id);

            await Collection.DeleteOneAsync(filter);
        }
        
    }
}
