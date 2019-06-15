namespace DOM.NET.Events
{
    public static class DomEvent
    {
        /// <summary>
        /// Fired when the loading of a resource has been aborted.
        /// </summary>
        public const string Abort = "abort";

        /// <summary>
        /// Fired when the print dialog is closed.
        /// </summary>
        public const string AfterPrint = "afterprint";

        /// <summary>
        /// Fired when a CSS animation has completed.
        /// </summary>
        public const string AnimationEnd = "animationend";

        /// <summary>
        /// Fired when a CSS animation is repeated.
        /// </summary>
        public const string AnimationIteration = "animationiteration";

        /// <summary>
        /// Fired when a CSS animation has started.
        /// </summary>
        public const string AnimationStart = "animationstart";

        /// <summary>
        /// Fired when the print dialog is opened.
        /// </summary>
        public const string BeforePrint = "beforeprint";
        public const string BeforeUnload = "beforeunload";
        public const string Blur = "blur";
        public const string CanPlay = "canplay";
        public const string CanPlayThrough = "canplaythrough";
        public const string Change = "change";
        public const string Click = "click";
        public const string ContextMenu = "contextmenu";

        /// <summary>
        /// Fired when the selection has been copied to the clipboard.
        /// </summary>
        public const string Copy = "copy";

        /// <summary>
        /// Fired when the selection has been cut and copied to the clipboard.
        /// </summary>
        public const string Cut = "cut";
        public const string DoubleClick = "dblclick";
        public const string Drag = "drag";
        public const string DragEnd = "dragend";
        public const string DragEnter = "dragenter";
        public const string DragLeave = "dragleave";
        public const string DragOver = "dragover";
        public const string DragStart = "dragstart";
        public const string Drop = "drop";
        public const string DurationChange = "durationchange";
        public const string Ended = "ended";
        public const string Error = "error";
        public const string Focus = "focus";
        public const string FocusIn = "focusin";
        public const string FocusOut = "focusout";

        /// <summary>
        /// Fired when an element was turned to fullscreen mode or back to normal mode.
        /// </summary>
        public const string FullScreenChange = "fullscreenchange";

        /// <summary>
        /// Fired when it is impossible to switch to fullscreen mode for technical reasons or because permission is denied.
        /// </summary>
        public const string FullScreenError = "fullscreenerror";
        public const string HashChange = "hashchange";
        public const string Input = "input";
        public const string Invalid = "invalid";

        /// <summary>
        /// Fired when any key is pressed.
        /// </summary>
        public const string KeyDown = "keydown";

        /// <summary>
        /// Fired continuously when any key except Shift, Fn, or CapsLock is in a pressed position.
        /// </summary>
        public const string KeyPress = "keypress";

        /// <summary>
        /// Fired when any key is released.
        /// </summary>
        public const string KeyUp = "keyup";
        public const string Load = "load";
        public const string LoadedData = "loadeddata";
        public const string LoadedMetadata = "loadedmetadata";
        public const string LoadStart = "loadstart";
        public const string Message = "message";
        public const string MouseDown = "mousedown";
        public const string MouseEnter = "mouseenter";
        public const string MouseLeave = "mouseleave";
        public const string MouseMove = "mousemove";
        public const string MouseOver = "mouseover";
        public const string MouseOut = "mouseout";
        public const string MouseUp = "mouseup";
        public const string Offline = "offline";
        public const string Online = "online";
        public const string Open = "open";

        /// <summary>
        /// Fired when a session history entry is being traversed from.
        /// </summary>
        public const string PageHide = "pagehide";

        /// <summary>
        /// Fired when a session history entry is being traversed to.
        /// </summary>
        public const string PageShow = "pageshow";

        /// <summary>
        /// Fired when the item from the clipboard has been pasted.
        /// </summary>
        public const string Paste = "paste";
        public const string Pause = "pause";
        public const string Play = "play";
        public const string Playing = "playing";

        /// <summary>
        /// Fired when a session history entry is being navigated to (in certain cases).
        /// </summary>
        public const string PopState = "popstate";
        public const string Progress = "progress";
        public const string RateChange = "ratechange";

        /// <summary>
        /// Fired when the document view has been resized.
        /// </summary>
        public const string Resize = "resize";

        /// <summary>
        /// Fired when the reset button is pressed.
        /// </summary>
        public const string Reset = "reset";

        /// <summary>
        /// Fired when the document view or an element has been scrolled.
        /// </summary>
        public const string Scroll = "scroll";
        public const string Search = "search";
        public const string Seeked = "seeked";
        public const string Seeking = "seeking";
        public const string Select = "select";
        public const string Show = "show";
        public const string Stalled = "stalled";
        public const string Storage = "storage";

        /// <summary>
        /// Fired when the submit button is pressed.
        /// </summary>
        public const string Submit = "submit";
        public const string Suspend = "suspend";
        public const string TimeUpdate = "timeupdate";
        public const string Toggle = "toggle";
        public const string TouchCancel = "touchcancel";
        public const string TouchEnd = "touchend";
        public const string TouchMove = "touchmove";
        public const string TouchStart = "touchstart";
        public const string TransitionEnd = "transitionend";
        public const string Unload = "unload";
        public const string VolumeChange = "volumechange";
        public const string Waiting = "waiting";

        /// <summary>
        /// Fired when a wheel button of a pointing device is rotated in any direction.
        /// </summary>
        public const string Wheel = "wheel";
    }
}