namespace Chat.Desktop
{
    /// <summary>
    /// This is a form for the user to type their name.
    /// </summary>
    public partial class InputName : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public InputName()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The method that is called when the ok button is clicked.
        /// </summary>
        /// <param name="sender">Data about the component that sends the message.</param>
        /// <param name="e">The current event arguments.</param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            UserManager.UserName = NameInput.Text;
            this.Close();
        }
    }
}
