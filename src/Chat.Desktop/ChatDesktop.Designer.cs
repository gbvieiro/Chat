namespace Chat.Desktop
{
    partial class ChatDesktop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Board = new System.Windows.Forms.TextBox();
            this.MessageInput = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.Color.Black;
            this.Board.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Board.Enabled = false;
            this.Board.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Board.Location = new System.Drawing.Point(233, 20);
            this.Board.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Board.Multiline = true;
            this.Board.Name = "Board";
            this.Board.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Board.Size = new System.Drawing.Size(693, 644);
            this.Board.TabIndex = 0;
            // 
            // MessageInput
            // 
            this.MessageInput.Location = new System.Drawing.Point(233, 675);
            this.MessageInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MessageInput.Name = "MessageInput";
            this.MessageInput.PlaceholderText = "Type a message...";
            this.MessageInput.Size = new System.Drawing.Size(579, 31);
            this.MessageInput.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(820, 667);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(106, 47);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ChatDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chat.Desktop.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessageInput);
            this.Controls.Add(this.Board);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ChatDesktop";
            this.ShowIcon = false;
            this.Text = "Chat Desktop";
            this.Load += new System.EventHandler(this.Chat_Desktop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Board;
        private TextBox MessageInput;
        private Button SendButton;
    }
}