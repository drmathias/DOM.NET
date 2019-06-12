namespace DOM.NET.Events
{
    /// <summary>
    /// Options that specify characteristics about an event listener.
    /// </summary>
    public class EventListenerOptions
    {
        /// <summary>
        /// Indicates whether events of this type will be dispatched to the registered listener before being dispatched to any EventTarget beneath it in the DOM tree
        /// </summary>
        public bool UseCapture { get; set; }

        /// <summary>
        /// Indicates whether the listener should be invoked at most once after being added.
        /// </summary>
        public bool Once { get; set; }

        /// <summary>
        /// Indicates whether the function specified by listener will never call preventDefault().
        /// </summary>
        public bool Passive { get; set; }
    }
}