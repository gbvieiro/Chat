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
            string text,
            DateTime sendingTime
        )
        {
            UserName = userName;
            Text = text;
            SendingTime = sendingTime;
        }

        /// <summary>
        /// Creates a new instance of a message.
        /// </summary>
        /// <param name="userName">
        /// The name of the user that has created the message.
        /// </param>
        /// <param name="text">
        /// The message text.
        /// </param>
        /// <returns>A new instance of a message domain model.</returns>
        public static Message CreateNew(
            string userName,
            string text
        ) => new(userName, text, new DateTime());
    }
}