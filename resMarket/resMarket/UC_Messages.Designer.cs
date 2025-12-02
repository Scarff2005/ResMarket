namespace resMarket
{
    partial class UC_Messages
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlConversations = new System.Windows.Forms.Panel();
            this.lstConversations = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlChatArea = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.flowChat = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlConversations.SuspendLayout();
            this.pnlChatArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConversations
            // 
            this.pnlConversations.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlConversations.Controls.Add(this.lstConversations);
            this.pnlConversations.Controls.Add(this.label1);
            this.pnlConversations.Location = new System.Drawing.Point(0, 0);
            this.pnlConversations.Name = "pnlConversations";
            this.pnlConversations.Size = new System.Drawing.Size(250, 660);
            this.pnlConversations.TabIndex = 0;
            this.pnlConversations.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlConversations_Paint);
            // 
            // lstConversations
            // 
            this.lstConversations.BackColor = System.Drawing.Color.White;
            this.lstConversations.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConversations.FormattingEnabled = true;
            this.lstConversations.ItemHeight = 23;
            this.lstConversations.Location = new System.Drawing.Point(10, 40);
            this.lstConversations.Name = "lstConversations";
            this.lstConversations.Size = new System.Drawing.Size(230, 579);
            this.lstConversations.TabIndex = 1;
            this.lstConversations.SelectedIndexChanged += new System.EventHandler(this.lstConversations_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversations";
            // 
            // pnlChatArea
            // 
            this.pnlChatArea.BackColor = System.Drawing.Color.White;
            this.pnlChatArea.Controls.Add(this.btnSend);
            this.pnlChatArea.Controls.Add(this.txtMessage);
            this.pnlChatArea.Controls.Add(this.flowChat);
            this.pnlChatArea.Location = new System.Drawing.Point(250, 0);
            this.pnlChatArea.Name = "pnlChatArea";
            this.pnlChatArea.Size = new System.Drawing.Size(535, 660);
            this.pnlChatArea.TabIndex = 1;
            this.pnlChatArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChatArea_Paint);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(420, 580);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 32);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(10, 580);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(400, 30);
            this.txtMessage.TabIndex = 0;
            // 
            // flowChat
            // 
            this.flowChat.AutoScroll = true;
            this.flowChat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowChat.Location = new System.Drawing.Point(10, 10);
            this.flowChat.Name = "flowChat";
            this.flowChat.Size = new System.Drawing.Size(515, 560);
            this.flowChat.TabIndex = 0;
            this.flowChat.Paint += new System.Windows.Forms.PaintEventHandler(this.flowChat_Paint);
            // 
            // UC_Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlChatArea);
            this.Controls.Add(this.pnlConversations);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Messages";
            this.Size = new System.Drawing.Size(785, 660);
            this.pnlConversations.ResumeLayout(false);
            this.pnlConversations.PerformLayout();
            this.pnlChatArea.ResumeLayout(false);
            this.pnlChatArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConversations;
        private System.Windows.Forms.ListBox lstConversations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlChatArea;
        private System.Windows.Forms.FlowLayoutPanel flowChat;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
    }
}
