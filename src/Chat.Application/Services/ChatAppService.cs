using AutoMapper;
using Chat.Application.DTOs;
using Chat.Application.Hubs;
using Chat.Application.Models;
using Chat.Domain.Models;
using Chat.Domain.Specifications;
using Microsoft.AspNetCore.SignalR;

namespace Chat.Application.Services
{
    /// <inheritdoc/>
    public class ChatAppService : AppService, IChatAppService
    {
        /// <summary>
        /// A service that provide business rules for the message model.
        /// </summary>
        private readonly IMessageValidator MessageValidator;

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
            IHubContext<ChatHub> chatHubContext,
            IMessageValidator messageValidator
        ) : base(mapper)
        {
            MessageValidator = messageValidator;
            ChatHubContext = chatHubContext;
        }

        /// <inheritdoc/>
        public async Task<ApplicationResponse> SendMessageAsync(
            MessageDto message
        )
        {
            return await ExecuteAction(async () =>
            {
                var newMessage = Message.CreateNew(
                    message.UserName,
                    message.Text
                );

                var validationResult =
                    await MessageValidator.ValidateAsync(newMessage);

                if (!validationResult.IsValid)
                {
                    var errorMessage =
                        string.Join(" ", validationResult.Errors.Select(x => x.ErrorMessage));

                    return ApplicationResponse.CreateError(
                        errorMessage, StatusCodeEnum.BadRequest
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