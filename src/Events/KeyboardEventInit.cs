namespace DOM.NET.Events
{
    /// <summary>
    /// Initialisation object to set properties on keyboard event creation.
    /// </summary>
    public class KeyboardEventInit : UIEventInit
    {
        /// <summary>
        /// Indicator for whether the ALT modifier key is pressed.
        /// </summary>
        public bool AltKey { get; set; }

        /// <summary>
        /// Indicator for whether the CTRL modifier key is pressed.
        /// </summary>
        public bool CtrlKey { get; set; }

        /// <summary>
        /// Indicates if the event is fired after compositionstart and before compositionend.
        /// </summary>
        public bool IsComposing { get; set; }

        /// <summary>
        /// The value of the key pressed by the user.
        /// </summary>
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// The location of the key on the keyboard.
        /// </summary>
        public KeyLocation Location { get; set; }

        /// <summary>
        /// Indicator for whether the META modifier key is pressed.
        /// </summary>
        public bool MetaKey { get; set; }

        /// <summary>
        /// Whether the key is being held down such that it is automatically repeating.
        /// </summary>
        public bool Repeat { get; set; }

        /// <summary>
        /// Indicator for whether the SHIFT modifier key is pressed.
        /// </summary>
        public bool ShiftKey { get; set; }
    }
}