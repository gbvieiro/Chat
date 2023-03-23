using Chat.Application.DTOs;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using System.Text;

namespace Chat.Desktop
{
    /// <summary>
    /// This is the main form of the project: The chat.
    /// </summary>
    public partial class ChatDesktop : Form
    {
        /// <summary>
        /// Current hub connection with the server.
        /// </summary>
        private readonly HubConnection HubConnection;

        /// <summary>
        /// A instance o httpClient that is used to create http request for the service.
        /// </summary>
        private static readonly HttpClient Client = new();

        /// <summary>
        /// Constructor.
        /// </summary>
        public ChatDesktop()
        {
            InitializeComponent();

            /// Build a new hub connection with the service.
            HubConnection =
                new HubConnectionBuilder()
                    .WithUrl("https://localhost:7195/ChatHub")
                    .Build();
        }

        /// <summary>
        /// This method runs during the form load. 
        /// Here the connection with the service is started.
        /// </summary>
        /// <param name="sender">Data about the component that sends the message.</param>
        /// <param name="e">The current event arguments.</param>
        private void Chat_Desktop_Load(object sender, EventArgs e)
        {
            var inputNameForm = new InputName();

            while (string.IsNullOrEmpty(UserManager.UserName))
            {
                inputNameForm.ShowDialog();
            }

            StartConnection();
        }

        /// <summary>
        /// This is a delegate method that is used to write the message on the board.
        /// It is important to avoid threads comunication problems.
        /// </summary>
        /// <param name="message">A new message.</param>
        private delegate void ReceberMensagemCallback(
            MessageDto message
        );

        private void StartConnection()
        {
            HubConnection.StartAsync();
            HubConnection.On<MessageDto>("broadcastMessage", (message) =>
            {
                WriteMessageOnBoard(message);
            });
        }

        /// <summary>
        /// The method that call the delegate method and write a message on the board.
        /// </summary>
        /// <param name="message">A new message.</param>
        private void WriteMessageOnBoard(
            MessageDto message
        )
        {
            if (InvokeRequired)
            {
                ReceberMensagemCallback callback = WriteMessageOnBoard;
                Invoke(callback, message);
            }
            else
            {
                Board.Text +=
                    "     " +
                    message.UserName
                    + ": "
                    + message.Text
                    + Environment.NewLine
                    + Environment.NewLine;
            }
        }

        /// <summary>
        /// This method is called when the sen button is clicked.
        /// This method gets the informed text, creates a new message and 
        /// send it to all connected users.
        /// </summary>
        /// <param name="sender">Data about the component that sends the message.</param>
        /// <param name="e">The current event arguments.</param>
        private async void SendButton_Click(object sender, EventArgs e)
        {
            var messageDto = new MessageDto()
            {
                Text = MessageInput.Text,
                UserName = UserManager.UserName
            };

            var json = JsonConvert.SerializeObject(messageDto);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(
                "https://localhost:7195/Chat/SendMessage",
                httpContent
            );

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Error to send the message.");
            }
            else
            {
                MessageInput.Text = string.Empty;
            }
        }
    }
}