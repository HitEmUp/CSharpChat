
namespace Chat
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbxLocalIP = new System.Windows.Forms.TextBox();
            this.tbxLocalPort = new System.Windows.Forms.TextBox();
            this.lbxChat = new System.Windows.Forms.ListBox();
            this.tbxChatToSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxRemotePort = new System.Windows.Forms.TextBox();
            this.tbxRemoteIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(233, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 51);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbxLocalIP
            // 
            this.tbxLocalIP.Location = new System.Drawing.Point(78, 14);
            this.tbxLocalIP.Name = "tbxLocalIP";
            this.tbxLocalIP.Size = new System.Drawing.Size(96, 20);
            this.tbxLocalIP.TabIndex = 1;
            this.tbxLocalIP.Text = "127.0.0.1";
            // 
            // tbxLocalPort
            // 
            this.tbxLocalPort.Location = new System.Drawing.Point(180, 14);
            this.tbxLocalPort.Name = "tbxLocalPort";
            this.tbxLocalPort.Size = new System.Drawing.Size(44, 20);
            this.tbxLocalPort.TabIndex = 2;
            this.tbxLocalPort.Text = "27000";
            // 
            // lbxChat
            // 
            this.lbxChat.FormattingEnabled = true;
            this.lbxChat.Location = new System.Drawing.Point(15, 89);
            this.lbxChat.Name = "lbxChat";
            this.lbxChat.Size = new System.Drawing.Size(430, 160);
            this.lbxChat.TabIndex = 4;
            // 
            // tbxChatToSend
            // 
            this.tbxChatToSend.Location = new System.Drawing.Point(15, 257);
            this.tbxChatToSend.Name = "tbxChatToSend";
            this.tbxChatToSend.Size = new System.Drawing.Size(349, 20);
            this.tbxChatToSend.TabIndex = 5;
            this.tbxChatToSend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxChatToSend_KeyUp);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(370, 255);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Remote IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Your IP:";
            // 
            // tbxRemotePort
            // 
            this.tbxRemotePort.Location = new System.Drawing.Point(180, 43);
            this.tbxRemotePort.Name = "tbxRemotePort";
            this.tbxRemotePort.Size = new System.Drawing.Size(44, 20);
            this.tbxRemotePort.TabIndex = 14;
            this.tbxRemotePort.Text = "27000";
            // 
            // tbxRemoteIP
            // 
            this.tbxRemoteIP.Location = new System.Drawing.Point(78, 43);
            this.tbxRemoteIP.Name = "tbxRemoteIP";
            this.tbxRemoteIP.Size = new System.Drawing.Size(96, 20);
            this.tbxRemoteIP.TabIndex = 13;
            this.tbxRemoteIP.Text = "127.0.0.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 298);
            this.Controls.Add(this.tbxRemotePort);
            this.Controls.Add(this.tbxRemoteIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxChatToSend);
            this.Controls.Add(this.lbxChat);
            this.Controls.Add(this.tbxLocalPort);
            this.Controls.Add(this.tbxLocalIP);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbxLocalIP;
        private System.Windows.Forms.TextBox tbxLocalPort;
        private System.Windows.Forms.ListBox lbxChat;
        private System.Windows.Forms.TextBox tbxChatToSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxRemotePort;
        private System.Windows.Forms.TextBox tbxRemoteIP;
    }
}

