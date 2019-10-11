using System;

namespace ChatWithMe.Storage
{
    public class DataSource : IDisposable
    {
        protected DatabaseContext MongoContext { get; }
        public AuthContext SqlContext { get; }

        public DataSource(DatabaseContext mongoContext, AuthContext sqlContext)
        {
            MongoContext = mongoContext;
            SqlContext = sqlContext;
        }

        // public UserRepository Users => new UserRepository(Context);


        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
