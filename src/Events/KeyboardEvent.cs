using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace DOM.NET.Events
{
    /// <summary>
    /// Describes a user interaction with the keyboard.
    /// </summary>
    public class KeyboardEvent : UIEvent
    {
        /// <summary>
        /// Creates a representation of a DOM KeyboardEvent with all properties set to their default value.
        /// </summary>
        /// <param name="jsRuntime">The runtime of the event.</param>
        /// <param name="type">A string representing the event type.</param>
        public KeyboardEvent(IJSRuntime jsRuntime, string type) : base(jsRuntime, type)
        {
        }

        /// <summary>
        /// Creates a representation of a DOM KeyboardEvent.
        /// </summary>
        /// <param name="jsRuntime">The runtime of the event.</param>
        /// <param name="type">A string representing the event type.</param>
        /// <param name="keyboardEventInit">The KeyboardEventInit object to set properties on the event.</param>
        public KeyboardEvent(IJSRuntime jsRuntime, string type, KeyboardEventInit keyboardEventInit) : base(jsRuntime, type, keyboardEventInit)
        {
            if (keyboardEventInit == null)
                throw new ArgumentNullException(nameof(keyboardEventInit));
            AltKey = keyboardEventInit.AltKey;
            CtrlKey = keyboardEventInit.CtrlKey;
            IsComposing = keyboardEventInit.IsComposing;
            Key = keyboardEventInit.Key;
            Location = keyboardEventInit.Location;
            MetaKey = keyboardEventInit.MetaKey;
            Repeat = keyboardEventInit.Repeat;
            ShiftKey = keyboardEventInit.ShiftKey;
        }

        public KeyboardEvent(IJSRuntime jsRuntime, bool bubbles, bool cancelable, bool composed, IEventTarget currentTarget, bool defaultPrevented,
            int eventPhase, IEventTarget target, string type, bool isTrusted, long detail, bool altKey, bool ctrlKey, bool isComposing, string key,
            ulong location, bool metaKey, bool repeat, bool shiftKey)
            : this(jsRuntime, bubbles, cancelable, composed, currentTarget, defaultPrevented, eventPhase, target, type, isTrusted, detail, altKey, ctrlKey,
                  isComposing, key, (KeyLocation)location, metaKey, repeat, shiftKey)
        {
        }

        public KeyboardEvent(IJSRuntime jsRuntime, bool bubbles, bool cancelable, bool composed, IEventTarget currentTarget, bool defaultPrevented,
            int eventPhase, IEventTarget target, string type, bool isTrusted, long detail, bool altKey, bool ctrlKey, bool isComposing, string key,
            KeyLocation location, bool metaKey, bool repeat, bool shiftKey)
            : base(jsRuntime, bubbles, cancelable, composed, currentTarget, defaultPrevented, eventPhase, target, type, isTrusted, detail)
        {
            AltKey = altKey;
            CtrlKey = ctrlKey;
            IsComposing = isComposing;
            Key = key;
            Location = location;
            MetaKey = metaKey;
            Repeat = repeat;
            ShiftKey = shiftKey;
        }

        /// <summary>
        /// Indicates whether the alt key was down when the event was fired.
        /// </summary>
        public bool AltKey { get; }

        /// <summary>
        /// Indicates whether the ctrl key was down when the event was fired.
        /// </summary>
        public bool CtrlKey { get; }

        /// <summary>
        /// Whether the event was fired between after compositionstart and before compositionend.
        /// </summary>
        public bool IsComposing { get; }

        /// <summary>
        /// The key value of the key represented by the event.
        /// </summary>
        public string Key { get; }

        /// <summary>
        /// Represents the location of the key on the keyboard or other input device.
        /// </summary>
        public KeyLocation Location { get; }

        /// <summary>
        /// Indicates whether the meta key was down when the event was fired.
        /// </summary>
        public bool MetaKey { get; }

        /// <summary>
        /// Indicates whether the key is held down such that it is automatically repeating.
        /// </summary>
        public bool Repeat { get; }

        /// <summary>
        /// Indicates whether the shift key was down when the event was fired.
        /// </summary>
        public bool ShiftKey { get; }

        /// <summary>
        /// Indicates if a modifier key such as Alt, Shift, Ctrl, or Meta, was pressed when the event was created.
        /// </summary>
        /// <returns>True if a modifier key was pressed when the event was created, otherwise false.</returns>
        public Task<bool> GetModifierState()
        {
            return _jsRuntime.InvokeAsync<bool>("keyboardEventApi.getModifierState");
        }
    }
}