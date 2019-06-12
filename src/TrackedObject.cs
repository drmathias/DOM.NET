using System;

namespace DOM.NET
{
    /// <summary>
    /// An object which is tracked in the JSInterop with via a reference identifier.
    /// </summary>
    public abstract class TrackedObject : IDisposable
    {
        protected int _reference;

        protected TrackedObject(int reference)
        {
            _reference = reference;
        }

        protected abstract void Dispose(bool disposing);

        public void Dispose()
        {
            Dispose(true);
        }

        ~TrackedObject()
        {
            Dispose(false);
        }
    }
}