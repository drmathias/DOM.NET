using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace DOM.NET.Events
{
    /// <summary>
    /// Represents events that occur due to the user interacting with a pointing device.
    /// </summary>
    public class MouseEvent : UIEvent
    {
        /// <summary>
        /// Creates a representation of a DOM MouseEvent with all properties set to their default value.
        /// </summary>
        /// <param name="jsRuntime">The runtime of the event.</param>
        /// <param name="type">A string representing the event type.</param>
        public MouseEvent(IJSRuntime jsRuntime, string type) : base(jsRuntime, type)
        {
        }

        /// <summary>
        /// Creates a representation of a DOM MouseEvent.
        /// </summary>
        /// <param name="jsRuntime">The runtime of the event.</param>
        /// <param name="type">A string representing the event type.</param>
        /// <param name="mouseEventInit">The MouseEventInit object to set properties on the event.</param>
        public MouseEvent(IJSRuntime jsRuntime, string type, MouseEventInit mouseEventInit) : base(jsRuntime, type, mouseEventInit)
        {
            if (mouseEventInit == null)
                throw new ArgumentNullException(nameof(mouseEventInit));
            AltKey = mouseEventInit.AltKey;
            Button = mouseEventInit.Button;
            Buttons = mouseEventInit.Buttons;
            ClientX = mouseEventInit.ClientX;
            ClientY = mouseEventInit.ClientY;
            CtrlKey = mouseEventInit.CtrlKey;
            MetaKey = mouseEventInit.MetaKey;
            Region = mouseEventInit.Region;
            RelatedTarget = mouseEventInit.RelatedTarget;
            ScreenX = mouseEventInit.ScreenX;
            ScreenY = mouseEventInit.ScreenY;
            ShiftKey = mouseEventInit.ShiftKey;
        }

        public MouseEvent(IJSRuntime jsRuntime, bool bubbles, bool cancelable, bool composed, IEventTarget currentTarget, bool defaultPrevented,
            int eventPhase, IEventTarget target, string type, bool isTrusted, long detail, bool altKey, int button, int buttons, double clientX,
            double clientY, bool ctrlKey, bool metaKey, double movementX, double movementY, string region, IEventTarget relatedTarget, double screenX,
            double screenY, bool shiftKey)
            : this(jsRuntime, bubbles, cancelable, composed, currentTarget, defaultPrevented, eventPhase, target, type, isTrusted, detail, altKey,
                  (MouseButtonType)button, (MouseButtonTypeFlags)buttons, clientX, clientY, ctrlKey, metaKey, movementX, movementY, region, relatedTarget,
                  screenX, screenY, shiftKey)
        {
        }

        public MouseEvent(IJSRuntime jsRuntime, bool bubbles, bool cancelable, bool composed, IEventTarget currentTarget, bool defaultPrevented,
            int eventPhase, IEventTarget target, string type, bool isTrusted, long detail, bool altKey, MouseButtonType button, MouseButtonTypeFlags buttons,
            double clientX, double clientY, bool ctrlKey, bool metaKey, double movementX, double movementY, string region, IEventTarget relatedTarget,
            double screenX, double screenY, bool shiftKey)
            : base(jsRuntime, bubbles, cancelable, composed, currentTarget, defaultPrevented, eventPhase, target, type, isTrusted, detail)
        {
            AltKey = altKey;
            Button = button;
            Buttons = buttons;
            ClientX = clientX;
            ClientY = clientY;
            CtrlKey = ctrlKey;
            MetaKey = metaKey;
            MovementX = movementX;
            MovementY = movementY;
            Region = region;
            RelatedTarget = relatedTarget;
            ScreenX = screenX;
            ScreenY = screenY;
            ShiftKey = shiftKey;
        }

        /// <summary>
        /// Indicates whether the alt key was down when the event was fired.
        /// </summary>
        public bool AltKey { get; }

        /// <summary>
        /// The button pressed when the event was fired.
        /// </summary>
        public MouseButtonType Button { get; }

        /// <summary>
        /// The buttons being depressed when the event was fired.
        /// </summary>
        public MouseButtonTypeFlags Buttons { get; }

        /// <summary>
        /// The X coordinate of the mouse pointer in local (DOM content) coordinates.
        /// </summary>
        public double ClientX { get; }

        /// <summary>
        /// The Y coordinate of the mouse pointer in local (DOM content) coordinates.
        /// </summary>
        public double ClientY { get; }

        /// <summary>
        /// Indicates whether the ctrl key was down when the event was fired.
        /// </summary>
        public bool CtrlKey { get; }

        /// <summary>
        /// Indicates whether the meta key was down when the event was fired.
        /// </summary>
        public bool MetaKey { get; }

        /// <summary>
        /// The X coordinate of the mouse pointer relative to the position of the last mousemove event.
        /// </summary>
        public double MovementX { get; }

        /// <summary>
        /// The Y coordinate of the mouse pointer relative to the position of the last mousemove event.
        /// </summary>
        public double MovementY { get; }

        /// <summary>
        /// The id of the hit region affected by the event, or null if no hit region is affected.
        /// </summary>
        public string Region { get; }

        /// <summary>
        /// The secondary target for the event, if there is one.
        /// </summary>
        public IEventTarget RelatedTarget { get; }

        /// <summary>
        /// The X coordinate of the mouse pointer in global (screen) coordinates.
        /// </summary>
        public double ScreenX { get; }

        /// <summary>
        /// The Y coordinate of the mouse pointer in global (screen) coordinates.
        /// </summary>
        public double ScreenY { get; }

        /// <summary>
        /// Indicates whether the shift key was down when the event was fired.
        /// </summary>
        public bool ShiftKey { get; }

        /// <summary>
        /// Returns whether or not the current state of the specified modifier key is active.
        /// </summary>
        /// <param name="key">The keyboard key.</param>
        /// <returns>True if the key is pressed or locked, otherwise false.</returns>
        public Task<bool> GetModifierState(string key)
        {
            return _jsRuntime.InvokeAsync<bool>("mouseEventApi.getModifierState", key);
        }
    }
}