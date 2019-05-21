using System;

namespace DOM.Standard.Events
{
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
