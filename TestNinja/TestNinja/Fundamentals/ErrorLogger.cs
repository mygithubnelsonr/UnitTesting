using System;

namespace TestNinja.Fundamentals
{
    public class ErrorLogger
    {
        public string LastError { get; set; }

        public event EventHandler<Guid> ErrorLogged;

        public void Log(string error)
        {
            if (String.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();

            LastError = error;

            // Write the log to a storage
            // ...

            // if you are outsource this error handler to a protected virtual void
            // the tests are still working
            //ErrorLogged?.Invoke(this, Guid.NewGuid());

            OnErrorLogged(Guid.NewGuid());

        }

        protected virtual void OnErrorLogged(Guid errorId)
        {
            ErrorLogged?.Invoke(this, errorId);
        }
    }
}