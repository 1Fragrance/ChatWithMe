using ChatWithMe.Common;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ChatWithMe.Storage
{
    public class DatabaseContext : IMongoContext
    {
        private readonly IMongoDatabase _db;
        private readonly MongoClient _client;

        public DatabaseContext(IOptions<AppConfig> config)
        {
            _client = new MongoClient(config.Value.MongoConfig.ConnectionString);
            _db = _client.GetDatabase(config.Value.MongoConfig.Database);
        }

        /// <summary>
        /// Data providers
        /// </summary>
        //public IMongoCollection<UserEntity> Users => _db.GetCollection<UserEntity>("Users");
    }

    public interface IMongoContext
    {
        //IMongoCollection<UserEntity> Users { get; }
    }
}
