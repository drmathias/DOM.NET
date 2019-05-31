namespace DOM.NET
{
    /// <summary>
    /// An object which is tracked in the JSInterop with via a reference identifier.
    /// </summary>
    public class TrackedObject
    {
        protected int _reference;

        public TrackedObject(int reference)
        {
            _reference = reference;
        }
    }
}