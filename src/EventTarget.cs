using DOM.NET.Events;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DOM.NET
{
    public class EventTarget : IDisposable, IEventTarget
    {
        private readonly IDictionary<int, Action> _actions;
        private readonly DotNetObjectRef _eventTargetObjectRef;
        protected readonly IJSInProcessRuntime _jsRuntime;

        public EventTarget(IJSRuntime jsRuntime)
        {
            _actions = new Dictionary<int, Action>();
            _eventTargetObjectRef = new DotNetObjectRef(this);
            _jsRuntime = (IJSInProcessRuntime)jsRuntime;
        }

        public Task AddEventListener(string domEventName, Action action)
        {
            _actions.Add(action.GetHashCode(), action);
            return _jsRuntime.InvokeAsync<object>("eventTargetApi.addEventListener", _eventTargetObjectRef, domEventName, action.GetHashCode(), false, false, false);
        }

        public Task AddEventListener(string domEventName, Action action, EventListenerOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));
            _actions.Add(action.GetHashCode(), action);
            return _jsRuntime.InvokeAsync<object>("eventTargetApi.addEventListener", _eventTargetObjectRef, domEventName, action.GetHashCode(),
                options.UseCapture, options.Once, options.Passive);
        }

        public Task RemoveEventListener(string domEventName, Action action)
        {
            _actions.Remove(action.GetHashCode());
            return _jsRuntime.InvokeAsync<object>("eventTargetApi.removeEventListener", _eventTargetObjectRef, domEventName, action.GetHashCode(), false, false, false);
        }

        public Task RemoveEventListener(string domEventName, Action action, EventListenerOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));
            _actions.Remove(action.GetHashCode());
            return _jsRuntime.InvokeAsync<object>("eventTargetApi.removeEventListener", _eventTargetObjectRef, domEventName, action.GetHashCode(),
                options.UseCapture, options.Once, options.Passive);
        }

        [JSInvokable]
        public void Invoke(int hash)
        {
            _actions[hash].Invoke();
        }

        protected virtual void Dispose(bool disposing)
        {
            _jsRuntime.UntrackObjectRef(_eventTargetObjectRef);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~EventTarget()
        {
            Dispose(false);
        }
    }
}