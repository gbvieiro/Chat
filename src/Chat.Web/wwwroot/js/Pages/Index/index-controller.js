// Prepare variables
var messageInput = document.getElementById("messageInput");
var board = document.getElementById("board");
var sendButton = document.getElementById("sendButton");

// User name is required, so the chat is just available after reading the user name.
var userName = null;
while (!userName) {
    userName = prompt("Please enter your name", "");
}

// When document is ready, start the connection and create pages methods
document.addEventListener('DOMContentLoaded', function () {

    // Start the connection with the hub on server.
    var connection = new signalR.HubConnectionBuilder()
        .withUrl('https://localhost:7195/ChatHub')
        .build();

    // This method will be listening for new messages.
    connection.on('broadcastMessage', function (message) {

        const template = `<div class="chat__conversation-board__message-container">
            <div class="chat__conversation-board__message__person">
                <span>` + message.userName + `:</span>
            </div>
            <div class="chat__conversation-board__message__context">
                <div class="chat__conversation-board__message__bubble">
                    <span>` + message.text + `</span>
                </div>
            </div>
        </div>`;

        board.innerHTML += template;
    });

    // Start the connection and set the click event listener
    connection.start().then(function () {
        sendButton.addEventListener('click', function (event) {

            if (messageInput.value && userName) {

                fetch('https://localhost:7195/Chat/SendMessage', {
                    method: 'POST',
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({
                        "userName": userName,
                        "text": messageInput.value
                    })
                }).then(response => {
                    console.log(response.json())

                    messageInput.value = '';
                    messageInput.focus();
                })
            }

            event.preventDefault();
        });
    }).catch(error => {
        alert(error.message);
    });
});