namespace Chat.Application.DTOs
{
    /// <summary>
    /// A model for tramport the message data.
    /// </summary>
    public class MessageDto
    {
        /// <summary>
        /// The name of the user that sends the message.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The message text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The message sending time.
        /// </summary>
        public DateTime SendingTime { get; set; }
    }
}