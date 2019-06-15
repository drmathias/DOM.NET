namespace DOM.NET.Events
{
    /// <summary>
    /// Initialisation object to set properties on mouse event creation.
    /// </summary>
    public class MouseEventInit : UIEventInit
    {
        /// <summary>
        /// Indicator for whether the ALT modifier key is pressed.
        /// </summary>
        public bool AltKey { get; set; }

        /// <summary>
        /// The button which is being pressed or released.
        /// </summary>
        public MouseButtonType Button { get; set; }

        /// <summary>
        /// The mouse buttons which are being pressed when the mouse event is created.
        /// </summary>
        public MouseButtonTypeFlags Buttons { get; set; }

        /// <summary>
        /// The horizontal position of the mouse event on the client window of the user's screen.
        /// </summary>
        public double ClientX { get; set; }

        /// <summary>
        /// The vertical position of the mouse event on the client window of the user's screen.
        /// </summary>
        public double ClientY { get; set; }

        /// <summary>
        /// Indicator for whether the CTRL modifier key is pressed.
        /// </summary>
        public bool CtrlKey { get; set; }

        /// <summary>
        /// Indicator for whether the META modifier key is pressed.
        /// </summary>
        public bool MetaKey { get; set; }

        /// <summary>
        /// The id of the hit region affected by the event.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// The element just left of the mouse (in case of  a mouseenter or mouseover) or that the mouse is entering (in case of a mouseout or mouseleave).
        /// </summary>
        public IEventTarget RelatedTarget { get; set; }

        /// <summary>
        /// The horizontal position of the mouse event on the user's screen
        /// </summary>
        public double ScreenX { get; set; }

        /// <summary>
        /// The vertical position of the mouse event on the user's screen
        /// </summary>
        public double ScreenY { get; set; }

        /// <summary>
        /// Indicator for whether the SHIFT modifier key is pressed.
        /// </summary>
        public bool ShiftKey { get; set; }
    }
}