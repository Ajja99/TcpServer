namespace KlientForm
{
    partial class Form1
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
            this.ipTextbox = new System.Windows.Forms.TextBox();
            this.klientButton = new System.Windows.Forms.Button();
            this.klientLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.chatTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ipTextbox
            // 
            this.ipTextbox.Location = new System.Drawing.Point(117, 17);
            this.ipTextbox.Name = "ipTextbox";
            this.ipTextbox.Size = new System.Drawing.Size(233, 26);
            this.ipTextbox.TabIndex = 0;
            // 
            // klientButton
            // 
            this.klientButton.Location = new System.Drawing.Point(12, 664);
            this.klientButton.Name = "klientButton";
            this.klientButton.Size = new System.Drawing.Size(487, 63);
            this.klientButton.TabIndex = 2;
            this.klientButton.Text = "Skicka";
            this.klientButton.UseVisualStyleBackColor = true;
            this.klientButton.Click += new System.EventHandler(this.klientButton_Click);
            // 
            // klientLabel
            // 
            this.klientLabel.AutoSize = true;
            this.klientLabel.Location = new System.Drawing.Point(356, 20);
            this.klientLabel.Name = "klientLabel";
            this.klientLabel.Size = new System.Drawing.Size(143, 20);
            this.klientLabel.TabIndex = 3;
            this.klientLabel.Text = "Serverns IP adress";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 600);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(487, 48);
            this.textBox1.TabIndex = 4;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(12, 12);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(99, 36);
            this.connectBtn.TabIndex = 5;
            this.connectBtn.Text = "connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // chatTextBox
            // 
            this.chatTextBox.Location = new System.Drawing.Point(13, 55);
            this.chatTextBox.Multiline = true;
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.Size = new System.Drawing.Size(486, 530);
            this.chatTextBox.TabIndex = 6;
            this.chatTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 739);
            this.Controls.Add(this.chatTextBox);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.klientLabel);
            this.Controls.Add(this.klientButton);
            this.Controls.Add(this.ipTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipTextbox;
        private System.Windows.Forms.Button klientButton;
        private System.Windows.Forms.Label klientLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox chatTextBox;
    }
}

