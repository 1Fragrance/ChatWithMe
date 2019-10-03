using System;
using System.Collections.Generic;
using System.Text;
using ChatWithMe.Storage.Repositories;

namespace ChatWithMe.Storage
{
    public class DataSource : IDisposable
    {
        protected DatabaseContext Context { get; }

        public DataSource(DatabaseContext context)
        {
            Context = context;
        }

        public UserRepository Users => new UserRepository(Context);


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
