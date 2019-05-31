using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace DOM.NET
{
    public class Document : IDocument
    {
        private readonly IJSRuntime _jsRuntime;

        internal Document(IJSRuntime jsRuntime)
        {
            _jsRuntime = (IJSInProcessRuntime)jsRuntime;
        }

        public async Task<IElement> GetElementById(string id)
        {
            var elementReference = await _jsRuntime.InvokeAsync<int>("documentApi.getElementById", id);
            return new Element(_jsRuntime, elementReference);
        }
    }
}