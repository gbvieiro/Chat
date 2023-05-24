using Microsoft.AspNetCore.Builder;

namespace Chat.Domain.Models
{
    /// <summary>
    /// The message domain model.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// The name of the user that has created the message.
        /// </summary>
        public string UserName { get; private set; }

        /// <summary>
        /// The message text.
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// The message sending time.
        /// </summary>
        public DateTime SendingTime { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="userName">
        /// The name of the user that has created the message.
        /// </param>
        /// <param name="text">
        /// The message text.
        /// </param>
        /// <param name="sendingTime">
        /// The message sending time.
        /// </param>
        public Message(
            string userName,
            string text
        )
        {
            UserName = userName;
            Text = text;
            SendingTime = new DateTime();
        }

        /// <summary>
        /// Verify if the current message state is valid.
        /// </summary>
        /// <returns>True if valid, false if not valid.</returns>
        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(UserName))
                return false;

            if (string.IsNullOrWhiteSpace(Text))
                return false;

            return true;
        }
    }
}