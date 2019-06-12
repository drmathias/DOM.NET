using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace DOM.NET
{
    public class Element : TrackedObject, IElement
    {
        private readonly IJSInProcessRuntime _jsRuntime;

        public Element(IJSRuntime jsRuntime, int reference) : base(reference)
        {
            _jsRuntime = (IJSInProcessRuntime)jsRuntime;
        }

        public string Id
        {
            get => _jsRuntime.Invoke<string>("elementApi.getId", _reference);
            set => _jsRuntime.Invoke<object>("elementApi.setId", _reference);
        }

        public Task ScrollIntoView()
        {
            return _jsRuntime.InvokeAsync<object>("elementApi.scrollIntoView", _reference);
        }

        protected override void Dispose(bool disposing)
        {
            _jsRuntime.Invoke<object>("elementApi.dispose", _reference);
        }
    }
}