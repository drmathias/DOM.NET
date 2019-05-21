using DOM.Standard.Events;
using System;

namespace DOM.Standard
{
    public interface IWindowApi
    {
        double ScreenX { get; }
        double ScreenY { get; }
        double ScrollX { get; }
        double ScrollY { get; }

        EventHandler<ScrollEventArgs> ScrollEvent { get; }
    }
}
