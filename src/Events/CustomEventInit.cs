namespace DOM.NET.Events
{
    /// <summary>
    /// Initialisation object to set properties on custom event creation.
    /// </summary>
    public class CustomEventInit : EventInit
    {
        /// <summary>
        /// An event-dependent value associated with the event.
        /// </summary>
        public object Detail { get; set; }
    }
}