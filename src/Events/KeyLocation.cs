namespace DOM.NET.Events
{
    /// <summary>
    /// Represents the location of a key on the keyboard or other input device.
    /// </summary>
    public enum KeyLocation
    {
        /// <summary>
        /// Represents a key with only one location, which can't be distinguished between the left and right versions of the key, and was not pressed on the
        /// numeric keypad or a key that is considered to be part of the keypad.
        /// </summary>
        Standard = 0,

        /// <summary>
        /// Represents the left-hand version of a key. This value is only used for keys that have more than one possible location on the keyboard.
        /// </summary>
        Left = 1,

        /// <summary>
        /// Represents the right-hand version of a key. This value is only used for keys that have more than one possible location on the keyboard.
        /// </summary>
        Right = 2,

        /// <summary>
        /// Represents a key on the numeric keypad, or a virtual key code that corresponds to the numeric keypad.
        /// </summary>
        Numpad = 3
    }
}