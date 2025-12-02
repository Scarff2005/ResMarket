namespace resMarket
{
    partial class frmViewItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSeller = new System.Windows.Forms.Label();
            this.btnMessageSeller = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // picItem
            // 
            this.picItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItem.Location = new System.Drawing.Point(20, 60);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(440, 200);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItem.TabIndex = 1;
            this.picItem.TabStop = false;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(20, 20);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(132, 31);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(20, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(20, 290);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(107, 23);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoEllipsis = true;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPrice.Location = new System.Drawing.Point(20, 360);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 28);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "R0.00";
            // 
            // lblSeller
            // 
            this.lblSeller.AutoEllipsis = true;
            this.lblSeller.AutoSize = true;
            this.lblSeller.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeller.ForeColor = System.Drawing.Color.Gray;
            this.lblSeller.Location = new System.Drawing.Point(20, 390);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(128, 23);
            this.lblSeller.TabIndex = 0;
            this.lblSeller.Text = "Seller: Unknown";
            // 
            // btnMessageSeller
            // 
            this.btnMessageSeller.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMessageSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessageSeller.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageSeller.ForeColor = System.Drawing.Color.White;
            this.btnMessageSeller.Location = new System.Drawing.Point(20, 430);
            this.btnMessageSeller.Name = "btnMessageSeller";
            this.btnMessageSeller.Size = new System.Drawing.Size(150, 35);
            this.btnMessageSeller.TabIndex = 4;
            this.btnMessageSeller.Text = "Message Seller";
            this.btnMessageSeller.UseVisualStyleBackColor = false;
            this.btnMessageSeller.Click += new System.EventHandler(this.btnMessageSeller_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(360, 430);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 482);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMessageSeller);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblSeller);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.picItem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmViewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Details";
            this.Load += new System.EventHandler(this.frmViewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.Button btnMessageSeller;
        private System.Windows.Forms.Button btnClose;
    }
}