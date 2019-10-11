using System;

namespace ChatWithMe.AuthStorage
{
    public class AuthDataSource : IDisposable
    {
        protected AuthContext AuthContext { get; }

        public AuthDataSource(AuthContext context)
        {
            AuthContext = context;
        }

        // Add repos there

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
