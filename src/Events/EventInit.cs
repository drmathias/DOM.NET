namespace DOM.NET.Events
{
    /// <summary>
    /// Initialisation object to set properties on event creation.
    /// </summary>
    public class EventInit
    {
        /// <summary>
        /// Decides whether the event should bubble up through the event chain or not. 
        /// </summary>
        public bool Bubbles { get; set; }
        /// <summary>
        /// Whether the event can be canceled.
        /// </summary>
        public bool Cancelable { get; set; }
        /// <summary>
        /// Indicates whether the event will trigger listeners outside of a shadow root.
        /// </summary>
        public bool Composed { get; set; }
    }
}