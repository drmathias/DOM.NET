using Microsoft.JSInterop;
using System;

namespace DOM.NET.Events
{
    /// <summary>
    /// Represents a UI event which takes place in the DOM.
    /// </summary>
    public class UIEvent : Event
    {

        /// <summary>
        /// Creates a representation of a DOM UIEvent with all properties set to their default value.
        /// </summary>
        /// <param name="jsRuntime">The runtime of the event.</param>
        /// <param name="type">A string representing the event type.</param>
        public UIEvent(IJSRuntime jsRuntime, string type) : base(jsRuntime, type)
        {
        }

        /// <summary>
        /// Creates a representation of a DOM UIEvent with all properties set to their default value.
        /// </summary>
        /// <param name="jsRuntime">The runtime of the event.</param>
        /// <param name="type">A string representing the event type.</param>
        /// <param name="uiEventInit">The UIEventInit object to set properties on the event.</param>
        public UIEvent(IJSRuntime jsRuntime, string type, UIEventInit uiEventInit) : base(jsRuntime, type, uiEventInit)
        {
            if (uiEventInit == null)
                throw new ArgumentNullException(nameof(uiEventInit));
            Detail = uiEventInit.Detail;
        }

        public UIEvent(IJSRuntime jsRuntime, bool bubbles, bool cancelable, bool composed, IEventTarget currentTarget, bool defaultPrevented, int eventPhase,
            IEventTarget target, string type, bool isTrusted, long detail)
            : base(jsRuntime, bubbles, cancelable, composed, currentTarget, defaultPrevented, eventPhase, target, type, isTrusted)
        {
            Detail = detail;
        }

        /// <summary>
        /// An event-dependant value associated with the event.
        /// </summary>
        public long Detail { get; }
    }
}