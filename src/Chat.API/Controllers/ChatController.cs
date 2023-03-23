using Chat.Application.DTOs;
using Chat.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Chat.API.Controllers
{
    /// <summary>
    /// The controller that provides methods for the chat API.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ChatController : BaseController
    {
        /// <summary>
        /// This is a service that provides access to the chat.Domain.
        /// </summary>
        private readonly IChatAppService ChatAppService;

        /// <summary>
        /// Construtor.
        /// </summary>
        /// <param name="chatAppService">
        /// The App Service instance provide by the IOC.
        /// </param>
        public ChatController(
            IChatAppService chatAppService
        ) : base()
        {
            ChatAppService = chatAppService;
        }

        /// <summary>
        /// This method sends messages for all connected users.
        /// </summary>
        /// <param name="message">
        /// A new message model.
        /// </param>
        /// <returns>
        /// A proper message response and status code.
        /// </returns>
        [HttpPost("sendMessage")]
        public async Task<IActionResult> SendMessageAsync(
            [FromBody] MessageDto message
        )
        {
            var result = await ChatAppService.SendMessageAsync(message);
            return ResponseWithJson(
                result.HasError ? result.ErrorMessage : "Success",
                result.StatusCode
            );
        }
    }
}