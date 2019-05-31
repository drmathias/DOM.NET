using DOM.NET.Events;
using System;
using System.Threading.Tasks;

namespace DOM.NET
{
    /// <summary>
    /// Represents the standardised DOM window API.
    /// </summary>
    public interface IWindow
    {
        /// <summary>
        /// Returns a reference to the document interface.
        /// </summary>
        IDocument Document { get; }

        /// <summary>
        /// Indicates whether the window is displayed in full screen mode or not.
        /// </summary>
        bool FullScreen { get; }

        /// <summary>
        /// Returns the number of frames in the window.
        /// </summary>
        int Length { get; }

        /// <summary>
        /// Returns the width (in pixels) of the browser window viewport including, if rendered, the vertical scrollbar.
        /// </summary>
        double InnerWidth { get; }

        /// <summary>
        /// Returns the height (in pixels) of the browser window viewport including, if rendered, the horizontal scrollbar.
        /// </summary>
        double InnerHeight { get; }

        /// <summary>
        /// Gets or sets the name of the window.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Returns the horizontal distance, in CSS pixels, of the left border of the user's browser viewport to the left side of the screen.
        /// </summary>
        double ScreenX { get; }

        /// <summary>
        /// Returns the vertical distance, in CSS pixels, of the top border of the user's browser viewport to the top edge of the screen.
        /// </summary>
        double ScreenY { get; }

        /// <summary>
        /// Returns the number of pixels that the document is currently scrolled horizontally.
        /// </summary>
        double ScrollX { get; }

        /// <summary>
        /// Returns the number of pixels that the document is currently scrolled vertically.
        /// </summary>
        double ScrollY { get; }

        /// <summary>
        /// Gets or sets the text in the status bar at the bottom of the browser or returns the previously set text.
        /// </summary>
        string Status { get; set; }

        /// <summary>
        /// The scroll event fires when the user scrolls the window. This event is invoked when window.onscroll is called.
        /// </summary>
        EventHandler<ScrollEventArgs> ScrollEvent { get; set; }

        Task Alert(string message);
        Task Blur();
    }
}