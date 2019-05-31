using System;

namespace DOM.NET.Events
{
    /// <summary>
    /// Arguments raised on a scroll event, providing the X and Y scroll position of the container.
    /// </summary>
    public class ScrollEventArgs : EventArgs
    {
        public ScrollEventArgs(double scrollX, double scrollY)
        {
            ScrollX = scrollX;
            ScrollY = scrollY;
        }

        public double ScrollX { get; }
        public double ScrollY { get; }
    }
}