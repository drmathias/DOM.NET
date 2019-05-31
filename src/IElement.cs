using System.Threading.Tasks;

namespace DOM.NET
{
    /// <summary>
    /// Represents the standardised DOM element API.
    /// </summary>
    public interface IElement
    {
        /// <summary>
        /// Represents the element's identifier, reflecting the id global attribute.
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// Scrolls the element into the visible area of the browser window.
        /// </summary>
        /// <returns>A task for the action.</returns>
        Task ScrollIntoView();
    }
}