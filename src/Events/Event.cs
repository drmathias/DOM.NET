using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace DOM.NET.Events
{
    /// <summary>
    /// Represents an event which takes place in the DOM.
    /// </summary>
    public class Event
    {
        protected readonly IJSRuntime _jsRuntime;

        /// <summary>
        /// Creates a representation of a DOM Event with all properties set to their default value.
        /// </summary>
        /// <param name="jsRuntime">The runtime of the event.</param>
        /// <param name="type">A string representing the event type.</param>
        public Event(IJSRuntime jsRuntime, string type)
        {
            _jsRuntime = jsRuntime;
            Type = type;
        }

        /// <summary>
        /// Creates a representation of a DOM Event.
        /// </summary>
        /// <param name="jsRuntime">The runtime of the event.</param>
        /// <param name="type">A string representing the event type.</param>
        /// <param name="eventInit">The EventInit object to set properties on the event.</param>
        public Event(IJSRuntime jsRuntime, string type, EventInit eventInit)
        {
            if (eventInit == null)
                throw new ArgumentNullException(nameof(eventInit));
            _jsRuntime = jsRuntime;
            Type = type;
            Bubbles = eventInit.Bubbles;
            Cancelable = eventInit.Cancelable;
            Composed = eventInit.Composed;
        }

        public Event(IJSRuntime jsRuntime, bool bubbles, bool cancelable, bool composed, IEventTarget currentTarget, bool defaultPrevented, int eventPhase,
            IEventTarget target, string type, bool isTrusted)
            : this(jsRuntime, bubbles, cancelable, composed, currentTarget, defaultPrevented, (EventPhase)eventPhase, target, type, isTrusted)
        {
        }

        public Event(IJSRuntime jsRuntime, bool bubbles, bool cancelable, bool composed, IEventTarget currentTarget, bool defaultPrevented,
            EventPhase eventPhase, IEventTarget target, string type, bool isTrusted)
        {
            _jsRuntime = jsRuntime;
            Bubbles = bubbles;
            Cancelable = cancelable;
            Composed = composed;
            CurrentTarget = currentTarget;
            DefaultPrevented = defaultPrevented;
            EventPhase = eventPhase;
            Target = target;
            Type = type;
            IsTrusted = isTrusted;
        }

        /// <summary>
        /// Indicates whether the event bubbles up through the DOM or not.
        /// </summary>
        public bool Bubbles { get; }

        /// <summary>
        /// Indicates whether the event is cancelable.
        /// </summary>
        public bool Cancelable { get; }

        /// <summary>
        /// Indicates whether or not the event can bubble across the boundary between the shadow DOM and the regular DOM.
        /// </summary>
        public bool Composed { get; }

        /// <summary>
        /// A reference to the currently registered target for the event. This is the object to which the event is currently slated to be sent; it's possible this has been changed along the way through retargeting.
        /// </summary>
        public IEventTarget CurrentTarget { get; }

        /// <summary>
        /// Indicates whether or not event.preventDefault() has been called on the event.
        /// </summary>
        public bool DefaultPrevented { get; }

        /// <summary>
        /// Indicates which phase of the event flow is being processed.
        /// </summary>
        public EventPhase EventPhase { get; }

        /// <summary>
        /// A reference to the target to which the event was originally dispatched.
        /// </summary>
        public IEventTarget Target { get; }

        /// <summary>
        /// The name of the event.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Indicates whether or not the event was initiated by the browser, or by a script.
        /// </summary>
        public bool IsTrusted { get; }

        /// <summary>
        /// Cancels the event, if it is cancellable.
        /// </summary>
        /// <returns>A task for the action.</returns>
        public Task PreventDefault()
        {
            return _jsRuntime.InvokeAsync<object>("eventTargetApi.preventDefault");
        }

        /// <summary>
        /// For this particular event, prevents other listeners being called.
        /// </summary>
        /// <returns>A task for the action.</returns>
        public Task StopImmediatePropagation()
        {
            return _jsRuntime.InvokeAsync<object>("eventTargetApi.stopImmediatePropagation");
        }

        /// <summary>
        /// Stops the propagation of events further along in the DOM.
        /// </summary>
        /// <returns>A task for the action.</returns>
        public Task StopPropagation()
        {
            return _jsRuntime.InvokeAsync<object>("eventTargetApi.stopPropagation");
        }
    }
}