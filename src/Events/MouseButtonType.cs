namespace DOM.NET.Events
{
    /// <summary>
    /// Mouse button types for the mouse event.
    /// </summary>
    public enum MouseButtonType
    {
        /// <summary>
        /// Usually the left button or unitialised state.
        /// </summary>
        Main = 0,
        /// <summary>
        /// Usually the wheel button or middle button.
        /// </summary>
        Auxiliary = 1,
        /// <summary>
        /// Usually the right button.
        /// </summary>
        Secondary = 2,
        /// <summary>
        /// Typically the browser back button.
        /// </summary>
        Fourth = 3,
        /// <summary>
        /// Typically the browser forward button.
        /// </summary>
        Fifth = 4
    }
}