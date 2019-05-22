using DOM.NET.Events;
using Microsoft.JSInterop;
using System;

namespace DOM.NET
{
    /// <summary>
    /// An interop of the DOM Window API accessed via JavaScript.
    /// </summary>
    public class WindowApi : IWindowApi
    {
        private readonly IJSInProcessRuntime _jsRuntime;

        public WindowApi(IJSRuntime jsRuntime)
        {
            _jsRuntime = (IJSInProcessRuntime)jsRuntime;
            _jsRuntime.InvokeAsync<object>("dotnetBlazorWindowApi", new DotNetObjectRef(this));
        }

        public bool FullScreen => _jsRuntime.Invoke<bool>("getFullScreen");
        public int Length => _jsRuntime.Invoke<int>("getLength");
        public double InnerWidth => _jsRuntime.Invoke<double>("getInnerWidth");
        public double InnerHeight => _jsRuntime.Invoke<double>("getInnerHeight");
        public string Name
        {
            get => _jsRuntime.Invoke<string>("getName");
            set => _jsRuntime.InvokeAsync<object>("setName", value);
        }
        public double ScreenX => _jsRuntime.Invoke<double>("getScreenX");
        public double ScreenY => _jsRuntime.Invoke<double>("getScreenY");
        public double ScrollX => _jsRuntime.Invoke<double>("getScrollX");
        public double ScrollY => _jsRuntime.Invoke<double>("getScrollY");
        public string Status
        {
            get => _jsRuntime.Invoke<string>("getStatus");
            set => _jsRuntime.InvokeAsync<object>("setStatus", value);
        }

        public EventHandler<ScrollEventArgs> ScrollEvent { get; set; }

        [JSInvokable]
        public void OnScroll(double scrollX, double scrollY)
        {
            ScrollEvent?.Invoke(this, new ScrollEventArgs(scrollX, scrollY));
        }
    }
}