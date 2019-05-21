using System;
using System.Collections.Generic;
using System.Text;
using DOM.Standard.Events;
using Microsoft.JSInterop;

namespace DOM.Standard
{
    public class WindowApi : IWindowApi
    {
        private readonly IJSRuntime _jsRuntime;

        public WindowApi(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
            _jsRuntime.InvokeAsync<object>("", new DotNetObjectRef(this));
        }

        public double ScreenX => _jsRuntime.InvokeAsync<double>("screenX").Result;
        public double ScreenY => _jsRuntime.InvokeAsync<double>("screenY").Result;
        public double ScrollX => _jsRuntime.InvokeAsync<double>("scrollX").Result;
        public double ScrollY => _jsRuntime.InvokeAsync<double>("scrollY").Result;

        public EventHandler<ScrollEventArgs> ScrollEvent { get; }

        [JSInvokable]
        public void OnScroll(double scrollX, double scrollY)
        {
            ScrollEvent?.Invoke(this, new ScrollEventArgs(scrollX, scrollY));
        }
    }
}