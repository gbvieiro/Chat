# Chat

This is an exercise of communicating a desktop application with a web application using the .NET CORE framework. It provides a robust architectural model based on Domain Driven Design. For creating this project was used ASP.NET 6.x.

# Software to Install

1. As this project works with .Net 6.x, I recommend to install Visual Studio 2022.
   Previous versions of Visual Studio maybe needs the .Net 6.x SDK installation.
   Link for downloading: https://visualstudio.microsoft.com/downloads/

2. For cloning this repository you must have git installed. If you don't have
   git installed get the last version here: https://git-scm.com/download/win

# Clone Repository

1. Click on "<> code" button. The code menu will be opened.

2. Select the HTTPS option on the clone section and use the button to copy the link.

3. Choose a directory to clone the repository, open a console and run:
   “git clone <past copied link>”.

# Build and Run

1. Open the directory where you clone the repository.

2. Open the solution file with Visual Studio 2022: “src\chat.sln”.

3. Once the visual studio is opened, make sure that all the 3 projects are selected as startup projects:

   3.1. Click the right button on the Solution.
   3.2. select an option called "Set Startup Projects".
   3.3. Select the option "Multiple Startup project".
   3.4. Make sure that these 3 projects as selected to start:

   - Chat.API
   - Chat.Desktop
   - Chat.Web

   This step is important because these 3 projects must be running for testing the solution.

   The solution is prepared to work with many instances.
   For this is necessary to build the project and run the Chat.Desktop ".exe" file.
   For the Chat.Web is possible to work like that just by opening many tabs.

4. When the projects start, inform a user name is necessary. This is important to identify the messages on the boards. As the user is informed, the chat is connected and will receive messages from the others connections. For better testing, make sure that the Desktop and Web versions are both connected, to see the messages being written down.

I hope that you enjoy the experience. Thank you!
