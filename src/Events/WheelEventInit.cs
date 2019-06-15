namespace DOM.NET.Events
{
    /// <summary>
    /// Initialisation object to set properties on wheel event creation.
    /// </summary>
    public class WheelEventInit : MouseEventInit
    {
        /// <summary>
        /// The horizontal scroll amount in the DeltaMode unit.
        /// </summary>
        public double DeltaX { get; set; }

        /// <summary>
        /// The vertical scroll amount in the DeltaMode unit.
        /// </summary>
        public double DeltaY { get; set; }

        /// <summary>
        /// The z-axis scroll amount in the DeltaMode unit.
        /// </summary>
        public double DeltaZ { get; set; }

        /// <summary>
        /// The scrolling unit for the delta values.
        /// </summary>
        public DeltaMode DeltaMode { get; set; }
    }
}