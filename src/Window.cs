﻿using DOM.NET.Events;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace DOM.NET
{
    /// <summary>
    /// An interop of the DOM Window API accessed via JavaScript.
    /// </summary>
    public class Window : EventTarget, IWindow
    {
        private readonly DotNetObjectRef _windowObjectRef;

        public Window(IJSRuntime jsRuntime) : base(jsRuntime)
        {
            Document = new Document(jsRuntime);
            _windowObjectRef = new DotNetObjectRef(this);
            _jsRuntime.InvokeAsync<object>("windowApi.subscribe", _windowObjectRef);
        }

        public IDocument Document { get; }
        public bool FullScreen => _jsRuntime.Invoke<bool>("windowApi.getFullScreen");
        public int Length => _jsRuntime.Invoke<int>("windowApi.getLength");
        public double InnerWidth => _jsRuntime.Invoke<double>("windowApi.getInnerWidth");
        public double InnerHeight => _jsRuntime.Invoke<double>("windowApi.getInnerHeight");
        public string Name
        {
            get => _jsRuntime.Invoke<string>("windowApi.getName");
            set => _jsRuntime.InvokeAsync<object>("windowApi.setName", value);
        }
        public double ScreenX => _jsRuntime.Invoke<double>("windowApi.getScreenX");
        public double ScreenY => _jsRuntime.Invoke<double>("windowApi.getScreenY");
        public double ScrollX => _jsRuntime.Invoke<double>("windowApi.getScrollX");
        public double ScrollY => _jsRuntime.Invoke<double>("windowApi.getScrollY");
        public string Status
        {
            get => _jsRuntime.Invoke<string>("windowApi.getStatus");
            set => _jsRuntime.InvokeAsync<object>("windowApi.setStatus", value);
        }

        public EventHandler<ScrollEventArgs> ScrollEvent { get; set; }

        public Task Alert(string message)
        {
            return _jsRuntime.InvokeAsync<object>("windowApi.alert", message);
        }

        public Task Blur()
        {
            return _jsRuntime.InvokeAsync<object>("windowApi.blur");
        }

        [JSInvokable]
        public void OnScroll(double scrollX, double scrollY)
        {
            ScrollEvent?.Invoke(this, new ScrollEventArgs(scrollX, scrollY));
        }

        protected override void Dispose(bool disposing)
        {
            _jsRuntime.UntrackObjectRef(_windowObjectRef);
            base.Dispose(disposing);
        }
    }
}