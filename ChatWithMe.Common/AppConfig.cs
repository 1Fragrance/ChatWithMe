using System.Collections.Generic;

namespace ChatWithMe.Common
{
    /// <summary>
    /// Application config
    /// </summary>
    public class AppConfig
    {
        public AppConfig()
        {
            MongoConfig = new MongoDbConfig();
            IdentityConfig = new IdentityConfig();
        }

        public MongoDbConfig MongoConfig { get; set; }
        public IdentityConfig IdentityConfig { get; set; }
    }

    /// <summary>
    /// MongoDb connection config
    /// </summary>
    public class MongoDbConfig
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }

    public class IdentityConfig
    {
    }
}
