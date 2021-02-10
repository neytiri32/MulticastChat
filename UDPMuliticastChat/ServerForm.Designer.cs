namespace UDPMuliticastChat
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
            this.lastMessage = new System.Windows.Forms.TextBox();
            this.messsagesHistory = new System.Windows.Forms.ListBox();
            this.newClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastMessage
            // 
            this.lastMessage.Location = new System.Drawing.Point(44, 37);
            this.lastMessage.Name = "lastMessage";
            this.lastMessage.ReadOnly = true;
            this.lastMessage.Size = new System.Drawing.Size(271, 22);
            this.lastMessage.TabIndex = 0;
            // 
            // messsagesHistory
            // 
            this.messsagesHistory.FormattingEnabled = true;
            this.messsagesHistory.ItemHeight = 16;
            this.messsagesHistory.Location = new System.Drawing.Point(44, 85);
            this.messsagesHistory.Name = "messsagesHistory";
            this.messsagesHistory.Size = new System.Drawing.Size(271, 276);
            this.messsagesHistory.TabIndex = 1;
            // 
            // newClientButton
            // 
            this.newClientButton.Location = new System.Drawing.Point(196, 377);
            this.newClientButton.Name = "newClientButton";
            this.newClientButton.Size = new System.Drawing.Size(119, 32);
            this.newClientButton.TabIndex = 2;
            this.newClientButton.Text = "New Client";
            this.newClientButton.UseVisualStyleBackColor = true;
            this.newClientButton.Click += new System.EventHandler(this.newClientButton_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 421);
            this.Controls.Add(this.newClientButton);
            this.Controls.Add(this.messsagesHistory);
            this.Controls.Add(this.lastMessage);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastMessage;
        private System.Windows.Forms.ListBox messsagesHistory;
        private System.Windows.Forms.Button newClientButton;
    }
}

