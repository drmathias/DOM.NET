using Microsoft.JSInterop;
using System;

namespace DOM.NET.Events
{
    /// <summary>
    /// Represents a wheel event which takes place in the DOM.
    /// </summary>
    public class WheelEvent : MouseEvent
    {
        /// <summary>
        /// Creates a representation of a DOM WheelEvent with all properties set to their default value.
        /// </summary>
        /// <param name="jsRuntime">The runtime of the event.</param>
        /// <param name="type">A string representing the event type.</param>
        public WheelEvent(IJSRuntime jsRuntime, string type) : base(jsRuntime, type)
        {
        }

        /// <summary>
        /// Creates a representation of a DOM WheelEvent.
        /// </summary>
        /// <param name="jsRuntime">The runtime of the event.</param>
        /// <param name="type">A string representing the event type.</param>
        /// <param name="wheelEventInit">The WheelEventInit object to set properties on the event.</param>
        public WheelEvent(IJSRuntime jsRuntime, string type, WheelEventInit wheelEventInit) : base(jsRuntime, type, wheelEventInit)
        {
            if (wheelEventInit == null)
                throw new ArgumentNullException(nameof(wheelEventInit));
            DeltaX = wheelEventInit.DeltaX;
            DeltaY = wheelEventInit.DeltaY;
            DeltaZ = wheelEventInit.DeltaZ;
            DeltaMode = wheelEventInit.DeltaMode;
        }

        public WheelEvent(IJSRuntime jsRuntime, bool bubbles, bool cancelable, bool composed, IEventTarget currentTarget, bool defaultPrevented,
            int eventPhase, IEventTarget target, string type, bool isTrusted, long detail, bool altKey, int button, int buttons, double clientX,
            double clientY, bool ctrlKey, bool metaKey, double movementX, double movementY, string region, IEventTarget relatedTarget, double screenX,
            double screenY, bool shiftKey, double deltaX, double deltaY, double deltaZ, DeltaMode deltaMode)
            : base(jsRuntime, bubbles, cancelable, composed, currentTarget, defaultPrevented, eventPhase, target, type, isTrusted, detail, altKey, button,
                  buttons, clientX, clientY, ctrlKey, metaKey, movementX, movementY, region, relatedTarget, screenX, screenY, shiftKey)
        {
            DeltaX = deltaX;
            DeltaY = deltaY;
            DeltaZ = deltaZ;
            DeltaMode = deltaMode;
        }

        /// <summary>
        /// The horizontal scroll amount.
        /// </summary>
        public double DeltaX { get; }

        /// <summary>
        /// The vertical scroll amount.
        /// </summary>
        public double DeltaY { get; }

        /// <summary>
        /// The scroll amount for the Z axis.
        /// </summary>
        public double DeltaZ { get; }

        /// <summary>
        /// The unit of the delta values' scroll amount.
        /// </summary>
        public DeltaMode DeltaMode { get; }
    }
}