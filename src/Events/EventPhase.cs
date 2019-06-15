namespace DOM.NET.Events
{
    /// <summary>
    /// Represents phases of the event flow.
    /// </summary>
    public enum EventPhase
    {
        /// <summary>
        /// No event is being processed at this time.
        /// </summary>
        None = 0,
        /// <summary>
        /// The event is being propagated through the target's ancestor objects.
        /// </summary>
        Capturing_Phase = 1,
        /// <summary>
        /// The event has arrived at the event's target.
        /// </summary>
        At_Target = 2,
        /// <summary>
        /// The event is propagating back up through the target's ancestors in reverse order, starting with the parent, and eventually reaching the containing Window.
        /// </summary>
        Bubbling_Phase = 3
    }
}