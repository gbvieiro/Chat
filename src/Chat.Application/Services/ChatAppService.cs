using AutoMapper;
using Chat.Application.DTOs;
using Chat.Application.Hubs;
using Chat.Application.Models;
using Chat.Domain.Models;
using Microsoft.AspNetCore.SignalR;

namespace Chat.Application.Services
{
    /// <inheritdoc/>
    public class ChatAppService : AppService, IChatAppService
    {
        /// <summary>
        /// A service that provides iteration wioth the chat hub.
        /// </summary>
        private readonly IHubContext<ChatHub> ChatHubContext;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="mapper">
        /// The current mapper service provide by the IOC.
        /// </param>
        /// <param name="chatHubContext">
        /// The chat hub instance provide by the IOC.
        /// </param>
        /// <param name="messageValidator">
        /// The Message Validator instance provide by the IOC.
        /// </param>
        public ChatAppService(
            IMapper mapper,
            IHubContext<ChatHub> chatHubContext
        ) : base(mapper)
        {
            ChatHubContext = chatHubContext;
        }

        /// <inheritdoc/>
        public async Task<ApplicationResponse> SendMessageAsync(
            MessageDto message
        )
        {
            return await ExecuteAction(async () =>
            {
                var newMessage = new Message(message.UserName, message.Text);

                if (!newMessage.IsValid())
                {
                    return ApplicationResponse.CreateError(
                        "Invalid Message",
                        StatusCodeEnum.BadRequest
                    );
                }

                await ChatHubContext.Clients.All.SendAsync(
                    "broadcastMessage",
                    newMessage
                );

                return ApplicationResponse.CreateSuccess();
            });
        }
    }
}