using Chat.Application.DTOs;
using Chat.Application.Models;

namespace Chat.Application.Services
{
    /// <summary>
    /// This is a service that provides access to the chat.Domain.
    /// </summary>
    public interface IChatAppService
    {
        /// <summary>
        /// Send a message for all connected users.
        /// </summary>
        /// <param name="message">The message parameters.</param>
        /// <returns>
        /// A application response with success or error.
        /// </returns>
        Task<ApplicationResponse> SendMessageAsync(MessageDto message);
    }
}