using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace DOM.NET
{
    public class Document : EventTarget, IDocument
    {
        internal Document(IJSRuntime jsRuntime) : base(jsRuntime)
        {
        }

        public async Task<IElement> GetElementById(string id)
        {
            var elementReference = await _jsRuntime.InvokeAsync<int>("documentApi.getElementById", id);
            return new Element(_jsRuntime, elementReference);
        }
    }
}