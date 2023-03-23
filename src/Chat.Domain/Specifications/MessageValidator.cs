using Chat.Domain.Models;
using FluentValidation;

namespace Chat.Domain.Specifications
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public class MessageValidator :
        AbstractValidator<Message>,
        IMessageValidator
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public MessageValidator()
        {
            DefineRules();
        }

        /// <summary>
        /// Define basis domain model validations.
        /// </summary>
        private void DefineRules()
        {
            RuleFor(Message => Message.Text).NotEmpty();
            RuleFor(Message => Message.UserName).NotEmpty();
            RuleFor(Message => Message.SendingTime).NotNull();
        }
    }
}