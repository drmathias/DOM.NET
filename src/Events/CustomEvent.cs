using Microsoft.JSInterop;
using System;

namespace DOM.NET.Events
{
    public class CustomEvent : Event
    {
        public CustomEvent(IJSRuntime jsRuntime, string type) : base(jsRuntime, type)
        {
        }

        public CustomEvent(IJSRuntime jsRuntime, string type, CustomEventInit customEventInit) : base(jsRuntime, type, customEventInit)
        {
            if (customEventInit == null)
                throw new ArgumentNullException(nameof(customEventInit));
            Detail = customEventInit.Detail;
        }

        public object Detail { get; }
    }
}