using DOM.Standard.Events;
using Microsoft.JSInterop;
using System;

namespace DOM.Standard
{
    /// <summary>
    /// An interop of the DOM Window API accessed via JavaScript.
    /// </summary>
    public class WindowApi : IWindowApi
    {
        private readonly IJSRuntime _jsRuntime;

        public WindowApi(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
            _jsRuntime.InvokeAsync<object>("", new DotNetObjectRef(this));
        }

        public bool FullScreen => _jsRuntime.InvokeAsync<bool>("fullScreen").Result;
        public int Length => _jsRuntime.InvokeAsync<int>("length").Result;
        public double InnerWidth => _jsRuntime.InvokeAsync<double>("innerWidth").Result;
        public double InnerHeight => _jsRuntime.InvokeAsync<double>("innerHeight").Result;
        public string Name
        {
            get => _jsRuntime.InvokeAsync<string>("name").Result;
            set => _jsRuntime.InvokeAsync<object>("name", value);
        }
        public double ScreenX => _jsRuntime.InvokeAsync<double>("screenX").Result;
        public double ScreenY => _jsRuntime.InvokeAsync<double>("screenY").Result;
        public double ScrollX => _jsRuntime.InvokeAsync<double>("scrollX").Result;
        public double ScrollY => _jsRuntime.InvokeAsync<double>("scrollY").Result;
        public string Status
        {
            get => _jsRuntime.InvokeAsync<string>("status").Result;
            set => _jsRuntime.InvokeAsync<object>("setStatus", value);
        }

        public EventHandler<ScrollEventArgs> ScrollEvent { get; }

        [JSInvokable]
        public void OnScroll(double scrollX, double scrollY)
        {
            ScrollEvent?.Invoke(this, new ScrollEventArgs(scrollX, scrollY));
        }
    }
}