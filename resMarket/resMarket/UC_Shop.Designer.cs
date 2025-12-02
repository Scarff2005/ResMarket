namespace resMarket
{
    partial class UC_Shop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblShopTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.lblItemDesc = new System.Windows.Forms.Label();
            this.txtItemDesc = new System.Windows.Forms.TextBox();
            this.lblItemPic = new System.Windows.Forms.Label();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.btnUploadPic = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShopTitle
            // 
            this.lblShopTitle.AutoSize = true;
            this.lblShopTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblShopTitle.Location = new System.Drawing.Point(28, 20);
            this.lblShopTitle.Name = "lblShopTitle";
            this.lblShopTitle.Size = new System.Drawing.Size(150, 45);
            this.lblShopTitle.TabIndex = 0;
            this.lblShopTitle.Text = "My Shop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upload and manage your items";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblItemName.ForeColor = System.Drawing.Color.Gray;
            this.lblItemName.Location = new System.Drawing.Point(30, 100);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(104, 25);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(140, 96);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(280, 27);
            this.txtItemName.TabIndex = 3;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblItemPrice.ForeColor = System.Drawing.Color.Gray;
            this.lblItemPrice.Location = new System.Drawing.Point(30, 140);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(79, 25);
            this.lblItemPrice.TabIndex = 4;
            this.lblItemPrice.Text = "Price (R):";
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemPrice.Location = new System.Drawing.Point(140, 136);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(150, 27);
            this.txtItemPrice.TabIndex = 5;
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.AutoSize = true;
            this.lblItemDesc.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblItemDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblItemDesc.Location = new System.Drawing.Point(30, 180);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(106, 25);
            this.lblItemDesc.TabIndex = 6;
            this.lblItemDesc.Text = "Description:";
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemDesc.Location = new System.Drawing.Point(140, 176);
            this.txtItemDesc.Multiline = true;
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.Size = new System.Drawing.Size(420, 60);
            this.txtItemDesc.TabIndex = 7;
            // 
            // lblItemPic
            // 
            this.lblItemPic.AutoSize = true;
            this.lblItemPic.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblItemPic.ForeColor = System.Drawing.Color.Gray;
            this.lblItemPic.Location = new System.Drawing.Point(30, 250);
            this.lblItemPic.Name = "lblItemPic";
            this.lblItemPic.Size = new System.Drawing.Size(69, 25);
            this.lblItemPic.TabIndex = 8;
            this.lblItemPic.Text = "Picture:";
            // 
            // picItem
            // 
            this.picItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItem.Location = new System.Drawing.Point(140, 250);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(120, 120);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItem.TabIndex = 9;
            this.picItem.TabStop = false;
            // 
            // btnUploadPic
            // 
            this.btnUploadPic.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUploadPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPic.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnUploadPic.ForeColor = System.Drawing.Color.White;
            this.btnUploadPic.Location = new System.Drawing.Point(270, 250);
            this.btnUploadPic.Name = "btnUploadPic";
            this.btnUploadPic.Size = new System.Drawing.Size(130, 32);
            this.btnUploadPic.TabIndex = 10;
            this.btnUploadPic.Text = "Upload Image";
            this.btnUploadPic.UseVisualStyleBackColor = false;
            this.btnUploadPic.Click += new System.EventHandler(this.btnUploadPic_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(140, 390);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(140, 36);
            this.btnAddItem.TabIndex = 11;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit,
            this.delete});
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.Location = new System.Drawing.Point(30, 440);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(720, 200);
            this.dgvItems.TabIndex = 12;
            this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            // 
            // edit
            // 
            this.edit.HeaderText = "Edit";
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.edit.Width = 125;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.delete.Width = 125;
            // 
            // UC_Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnUploadPic);
            this.Controls.Add(this.picItem);
            this.Controls.Add(this.lblItemPic);
            this.Controls.Add(this.txtItemDesc);
            this.Controls.Add(this.lblItemDesc);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblShopTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Shop";
            this.Size = new System.Drawing.Size(785, 825);
            this.Load += new System.EventHandler(this.UC_Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShopTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.Label lblItemDesc;
        private System.Windows.Forms.TextBox txtItemDesc;
        private System.Windows.Forms.Label lblItemPic;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.Button btnUploadPic;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn delete;
    }
}
