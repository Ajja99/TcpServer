namespace TcpServer
{
    partial class ServerForm
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
            this.serverButton = new System.Windows.Forms.Button();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serverButton
            // 
            this.serverButton.Location = new System.Drawing.Point(12, 613);
            this.serverButton.Name = "serverButton";
            this.serverButton.Size = new System.Drawing.Size(500, 90);
            this.serverButton.TabIndex = 0;
            this.serverButton.Text = "Starta Server";
            this.serverButton.UseVisualStyleBackColor = true;
            this.serverButton.Click += new System.EventHandler(this.serverButton_Click);
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(13, 13);
            this.serverTextBox.Multiline = true;
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(499, 594);
            this.serverTextBox.TabIndex = 1;
            // 
            // ServerForm
            // 
            this.ClientSize = new System.Drawing.Size(527, 715);
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(this.serverButton);
            this.Name = "ServerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button serverButton;
        private System.Windows.Forms.TextBox serverTextBox;
    }
}

