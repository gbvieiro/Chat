using Chat.Domain.Models;
using FluentValidation;

namespace Chat.Domain.Specifications
{
    /// <summary>
    /// This class provides business validations for the message domain model.
    /// </summary>
    public interface IMessageValidator : IValidator<Message> { }
}