namespace DOM.NET.Events
{
    /// <summary>
    /// Represents the unit of the delta values scroll amount.
    /// </summary>
    public enum DeltaMode
    {
        /// <summary>
        /// The delta values are specified in pixels.
        /// </summary>
        Pixel = 0x00,
        /// <summary>
        /// The delta values are specified in lines.
        /// </summary>
        Line = 0x01,
        /// <summary>
        /// The delta values are specified in pages.
        /// </summary>
        Page = 0x02
    }
}