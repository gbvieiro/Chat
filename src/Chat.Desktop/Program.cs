namespace Chat.Desktop
{
    /// <summary>
    /// this class is the entry point for the project.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new ChatDesktop());
        }
    }
}