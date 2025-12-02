namespace resMarket
{
    partial class UC_Browse
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.flowListings = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTitles = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.pnlFilter.SuspendLayout();
            this.flowListings.SuspendLayout();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(16, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Browse Listings";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFilter.Controls.Add(this.btnSearch);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Location = new System.Drawing.Point(16, 60);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(750, 48);
            this.pnlFilter.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(494, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(8, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(465, 30);
            this.txtSearch.TabIndex = 1;
            // 
            // flowListings
            // 
            this.flowListings.AutoScroll = true;
            this.flowListings.BackColor = System.Drawing.Color.Transparent;
            this.flowListings.Controls.Add(this.pnlCard);
            this.flowListings.Location = new System.Drawing.Point(16, 120);
            this.flowListings.Name = "flowListings";
            this.flowListings.Size = new System.Drawing.Size(750, 520);
            this.flowListings.TabIndex = 2;
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.btnView);
            this.pnlCard.Controls.Add(this.label1);
            this.pnlCard.Controls.Add(this.lblCategory);
            this.pnlCard.Controls.Add(this.lblTitles);
            this.pnlCard.Controls.Add(this.picImage);
            this.pnlCard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCard.Location = new System.Drawing.Point(8, 8);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(8);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(350, 200);
            this.pnlCard.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.DarkGreen;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(260, 158);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(80, 28);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(8, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "R100";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Gray;
            this.lblCategory.Location = new System.Drawing.Point(8, 140);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 20);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // lblTitles
            // 
            this.lblTitles.AutoSize = true;
            this.lblTitles.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitles.Location = new System.Drawing.Point(8, 116);
            this.lblTitles.Name = "lblTitles";
            this.lblTitles.Size = new System.Drawing.Size(118, 25);
            this.lblTitles.TabIndex = 1;
            this.lblTitles.Text = "Sample Item";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(8, 8);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(334, 100);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // UC_Browse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowListings);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_Browse";
            this.Size = new System.Drawing.Size(785, 660);
            this.Load += new System.EventHandler(this.UC_Browse_Load);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.flowListings.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowListings;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTitles;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label1;
    }
}
