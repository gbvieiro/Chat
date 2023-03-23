namespace Chat.Desktop
{
    partial class InputName
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnterYourNameLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterYourNameLabel
            // 
            this.EnterYourNameLabel.AutoSize = true;
            this.EnterYourNameLabel.Location = new System.Drawing.Point(9, 9);
            this.EnterYourNameLabel.Name = "EnterYourNameLabel";
            this.EnterYourNameLabel.Size = new System.Drawing.Size(133, 15);
            this.EnterYourNameLabel.TabIndex = 0;
            this.EnterYourNameLabel.Text = "Please enter your name:";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(9, 27);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(250, 23);
            this.NameInput.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(265, 27);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // InputName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 59);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.EnterYourNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputName";
            this.ShowIcon = false;
            this.Text = "Welcome to Chat Desktop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label EnterYourNameLabel;
        private TextBox NameInput;
        private Button OkButton;
    }
}