using System;

namespace DOM.NET.Events
{
    /// <summary>
    /// Mouse button flags for the mouse event.
    /// </summary>
    [Flags]
    public enum MouseButtonTypeFlags
    {
        /// <summary>
        /// No button or unitialised state.
        /// </summary>
        None = 0,
        /// <summary>
        /// Usually the left button.
        /// </summary>
        Primary = 1,
        /// <summary>
        /// Usually the right button.
        /// </summary>
        Secondary = 2,
        /// <summary>
        /// Usually the wheel button or middle button.
        /// </summary>
        Auxiliary = 4,
        /// <summary>
        /// Typically the browser back button.
        /// </summary>
        Fourth = 8,
        /// <summary>
        /// Typically the browser forward button.
        /// </summary>
        Fifth = 16
    }
}