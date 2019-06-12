using DOM.NET.Events;
using System;
using System.Threading.Tasks;

namespace DOM.NET
{
    /// <summary>
    /// Represents the standardised DOM EventTarget API.
    /// </summary>
    public interface IEventTarget
    {
        /// <summary>
        /// Sets up a function that will be called whenever the specified event is delivered to the target.
        /// </summary>
        /// <param name="domEventName">The dom event listened for.</param>
        /// <param name="action">The action invoked in response to the event.</param>
        /// <returns>A task for the action.</returns>
        Task AddEventListener(string domEventName, Action action);

        /// <summary>
        /// Sets up a function that will be called whenever the specified event is delivered to the target.
        /// </summary>
        /// <param name="domEventName">The dom event listened for.</param>
        /// <param name="action">The action invoked in response to the event.</param>
        /// <param name="options">An options object that specifies characteristics about the event listener.</param>
        /// <returns>A task for the action.</returns>
        Task AddEventListener(string domEventName, Action action, EventListenerOptions options);

        /// <summary>
        /// Removes an event listener previously registered.
        /// </summary>
        /// <param name="domEventName">The dom event listened for.</param>
        /// <param name="action">The action invoked in response to the event.</param>
        /// <returns>A task for the action.</returns>
        Task RemoveEventListener(string domEventName, Action action);

        /// <summary>
        /// Removes an event listener previously registered.
        /// </summary>
        /// <param name="domEventName">The dom event listened for.</param>
        /// <param name="action">The action invoked in response to the event.</param>
        /// <param name="options">An options object that specifies characteristics about the event listener.</param>
        /// <returns>A task for the action.</returns>
        Task RemoveEventListener(string domEventName, Action action, EventListenerOptions options);
    }
}