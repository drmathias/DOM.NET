using System.Threading.Tasks;

namespace DOM.NET
{
    /// <summary>
    /// Represents the standardised DOM document API.
    /// </summary>
    public interface IDocument : IEventTarget
    {
        /// <summary>
        /// Returns an Element object representing the element whose id property matches the specified string.
        /// </summary>
        /// <param name="id">The ID of the element to locate. The ID is case-sensitive string which is unique within the document; only one element may have any given ID.</param>
        /// <returns>A task for the action.</returns>
        Task<IElement> GetElementById(string id);
    }
}