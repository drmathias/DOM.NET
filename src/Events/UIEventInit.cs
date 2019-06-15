namespace DOM.NET.Events
{
    /// <summary>
    /// Initialisation object to set properties on UI event creation.
    /// </summary>
    public class UIEventInit : EventInit
    {
        /// <summary>
        /// An event-dependant value associated with the event.
        /// </summary>
        public long Detail { get; set; }
    }
}