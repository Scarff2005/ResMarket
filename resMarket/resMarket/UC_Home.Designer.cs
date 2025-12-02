namespace resMarket
{
    partial class UC_Home
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowListings = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTitles = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.flowListings.SuspendLayout();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(16, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Featured Listings";
            // 
            // flowListings
            // 
            this.flowListings.AutoScroll = true;
            this.flowListings.Controls.Add(this.pnlCard);
            this.flowListings.Location = new System.Drawing.Point(16, 60);
            this.flowListings.Name = "flowListings";
            this.flowListings.Size = new System.Drawing.Size(750, 580);
            this.flowListings.TabIndex = 1;
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.btnView);
            this.pnlCard.Controls.Add(this.lblPrice);
            this.pnlCard.Controls.Add(this.lblCategory);
            this.pnlCard.Controls.Add(this.lblTitles);
            this.pnlCard.Controls.Add(this.picImage);
            this.pnlCard.Location = new System.Drawing.Point(8, 8);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(8);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(350, 200);
            this.pnlCard.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.DarkGreen;
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(260, 158);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(80, 28);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPrice.Location = new System.Drawing.Point(8, 160);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 23);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "R50";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCategory.ForeColor = System.Drawing.Color.Gray;
            this.lblCategory.Location = new System.Drawing.Point(8, 140);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(54, 20);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Baking";
            // 
            // lblTitles
            // 
            this.lblTitles.AutoSize = true;
            this.lblTitles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitles.Location = new System.Drawing.Point(8, 116);
            this.lblTitles.Name = "lblTitles";
            this.lblTitles.Size = new System.Drawing.Size(189, 25);
            this.lblTitles.TabIndex = 3;
            this.lblTitles.Text = "Chocolate Cupcakes";
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.LightGray;
            this.picImage.Location = new System.Drawing.Point(8, 8);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(334, 100);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 4;
            this.picImage.TabStop = false;
            // 
            // UC_Home
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.flowListings);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(785, 660);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.flowListings.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowListings;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblTitles;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnView;
    }
}
