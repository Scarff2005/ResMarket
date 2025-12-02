namespace resMarket
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picTopUser = new System.Windows.Forms.PictureBox();
            this.lblTopUserName = new System.Windows.Forms.Label();
            this.pnlLeftNav = new System.Windows.Forms.Panel();
            this.btnNavProfile = new System.Windows.Forms.Button();
            this.btnNavMessages = new System.Windows.Forms.Button();
            this.btnNavShop = new System.Windows.Forms.Button();
            this.btnNavBrowse = new System.Windows.Forms.Button();
            this.btnNavHome = new System.Windows.Forms.Button();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.lblSideUserName = new System.Windows.Forms.Label();
            this.picSideUser = new System.Windows.Forms.PictureBox();
            this.btnNavLogout = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.flowListings = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlListingCard = new System.Windows.Forms.Panel();
            this.btnListingView = new System.Windows.Forms.Button();
            this.lblListingOwner = new System.Windows.Forms.Label();
            this.lblListingPrice = new System.Windows.Forms.Label();
            this.lblListingCategory = new System.Windows.Forms.Label();
            this.lblListingTitle = new System.Windows.Forms.Label();
            this.picListingImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlFilterBar = new System.Windows.Forms.Panel();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.pnlHero = new System.Windows.Forms.Panel();
            this.lblHeroSubtitle = new System.Windows.Forms.Label();
            this.lblHeroTitle = new System.Windows.Forms.Label();
            this.lblFooterVersion = new System.Windows.Forms.Label();
            this.lblFooterLeft = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopUser)).BeginInit();
            this.pnlLeftNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSideUser)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.flowListings.SuspendLayout();
            this.pnlListingCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picListingImage)).BeginInit();
            this.pnlFilterBar.SuspendLayout();
            this.pnlHero.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Controls.Add(this.label1);
            this.pnlTopBar.Controls.Add(this.picLogo);
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1345, 70);
            this.pnlTopBar.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(16, 8);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 54);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // picTopUser
            // 
            this.picTopUser.Image = ((System.Drawing.Image)(resources.GetObject("picTopUser.Image")));
            this.picTopUser.Location = new System.Drawing.Point(986, 15);
            this.picTopUser.Name = "picTopUser";
            this.picTopUser.Size = new System.Drawing.Size(44, 44);
            this.picTopUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTopUser.TabIndex = 5;
            this.picTopUser.TabStop = false;
            // 
            // lblTopUserName
            // 
            this.lblTopUserName.AutoSize = true;
            this.lblTopUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopUserName.Location = new System.Drawing.Point(1036, 22);
            this.lblTopUserName.Name = "lblTopUserName";
            this.lblTopUserName.Size = new System.Drawing.Size(143, 23);
            this.lblTopUserName.TabIndex = 6;
            this.lblTopUserName.Text = "Sibusiso Dlamini";
            // 
            // pnlLeftNav
            // 
            this.pnlLeftNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(90)))), ((int)(((byte)(47)))));
            this.pnlLeftNav.Controls.Add(this.btnNavProfile);
            this.pnlLeftNav.Controls.Add(this.btnNavMessages);
            this.pnlLeftNav.Controls.Add(this.btnNavShop);
            this.pnlLeftNav.Controls.Add(this.btnNavBrowse);
            this.pnlLeftNav.Controls.Add(this.btnNavHome);
            this.pnlLeftNav.Controls.Add(this.pnlDivider);
            this.pnlLeftNav.Controls.Add(this.lblSideUserName);
            this.pnlLeftNav.Controls.Add(this.picSideUser);
            this.pnlLeftNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftNav.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftNav.Name = "pnlLeftNav";
            this.pnlLeftNav.Size = new System.Drawing.Size(260, 898);
            this.pnlLeftNav.TabIndex = 9;
            // 
            // btnNavProfile
            // 
            this.btnNavProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProfile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavProfile.ForeColor = System.Drawing.Color.White;
            this.btnNavProfile.Location = new System.Drawing.Point(10, 394);
            this.btnNavProfile.Name = "btnNavProfile";
            this.btnNavProfile.Size = new System.Drawing.Size(240, 48);
            this.btnNavProfile.TabIndex = 16;
            this.btnNavProfile.Text = "Profile";
            this.btnNavProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavProfile.UseVisualStyleBackColor = true;
            this.btnNavProfile.Click += new System.EventHandler(this.btnNavProfile_Click);
            // 
            // btnNavMessages
            // 
            this.btnNavMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMessages.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavMessages.ForeColor = System.Drawing.Color.White;
            this.btnNavMessages.Location = new System.Drawing.Point(10, 340);
            this.btnNavMessages.Name = "btnNavMessages";
            this.btnNavMessages.Size = new System.Drawing.Size(240, 48);
            this.btnNavMessages.TabIndex = 14;
            this.btnNavMessages.Text = "Messages";
            this.btnNavMessages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavMessages.UseVisualStyleBackColor = true;
            this.btnNavMessages.Click += new System.EventHandler(this.btnNavMessages_Click_1);
            // 
            // btnNavShop
            // 
            this.btnNavShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavShop.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavShop.ForeColor = System.Drawing.Color.White;
            this.btnNavShop.Location = new System.Drawing.Point(10, 286);
            this.btnNavShop.Name = "btnNavShop";
            this.btnNavShop.Size = new System.Drawing.Size(240, 48);
            this.btnNavShop.TabIndex = 12;
            this.btnNavShop.Text = "My Shop";
            this.btnNavShop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavShop.UseVisualStyleBackColor = true;
            this.btnNavShop.Click += new System.EventHandler(this.btnNavShop_Click);
            // 
            // btnNavBrowse
            // 
            this.btnNavBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBrowse.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavBrowse.ForeColor = System.Drawing.Color.White;
            this.btnNavBrowse.Location = new System.Drawing.Point(10, 232);
            this.btnNavBrowse.Name = "btnNavBrowse";
            this.btnNavBrowse.Size = new System.Drawing.Size(240, 48);
            this.btnNavBrowse.TabIndex = 10;
            this.btnNavBrowse.Text = "Browse";
            this.btnNavBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBrowse.UseVisualStyleBackColor = true;
            this.btnNavBrowse.Click += new System.EventHandler(this.btnNavBrowse_Click);
            // 
            // btnNavHome
            // 
            this.btnNavHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHome.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavHome.ForeColor = System.Drawing.Color.White;
            this.btnNavHome.Location = new System.Drawing.Point(10, 178);
            this.btnNavHome.Name = "btnNavHome";
            this.btnNavHome.Size = new System.Drawing.Size(240, 48);
            this.btnNavHome.TabIndex = 3;
            this.btnNavHome.Text = "Home";
            this.btnNavHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavHome.UseVisualStyleBackColor = true;
            this.btnNavHome.Click += new System.EventHandler(this.btnNavHome_Click);
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(63)))), ((int)(((byte)(42)))));
            this.pnlDivider.Location = new System.Drawing.Point(10, 170);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(240, 1);
            this.pnlDivider.TabIndex = 2;
            // 
            // lblSideUserName
            // 
            this.lblSideUserName.AutoSize = true;
            this.lblSideUserName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSideUserName.ForeColor = System.Drawing.Color.White;
            this.lblSideUserName.Location = new System.Drawing.Point(100, 92);
            this.lblSideUserName.Name = "lblSideUserName";
            this.lblSideUserName.Size = new System.Drawing.Size(0, 17);
            this.lblSideUserName.TabIndex = 1;
            // 
            // picSideUser
            // 
            this.picSideUser.Image = ((System.Drawing.Image)(resources.GetObject("picSideUser.Image")));
            this.picSideUser.Location = new System.Drawing.Point(10, 82);
            this.picSideUser.Name = "picSideUser";
            this.picSideUser.Size = new System.Drawing.Size(80, 80);
            this.picSideUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSideUser.TabIndex = 0;
            this.picSideUser.TabStop = false;
            // 
            // btnNavLogout
            // 
            this.btnNavLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnNavLogout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavLogout.Location = new System.Drawing.Point(10, 672);
            this.btnNavLogout.Name = "btnNavLogout";
            this.btnNavLogout.Size = new System.Drawing.Size(240, 48);
            this.btnNavLogout.TabIndex = 10;
            this.btnNavLogout.Text = "Logout";
            this.btnNavLogout.UseVisualStyleBackColor = false;
            this.btnNavLogout.Click += new System.EventHandler(this.btnNavLogout_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContent.Controls.Add(this.flowListings);
            this.pnlContent.Controls.Add(this.pnlFilterBar);
            this.pnlContent.Controls.Add(this.pnlHero);
            this.pnlContent.Controls.Add(this.lblFooterVersion);
            this.pnlContent.Controls.Add(this.lblFooterLeft);
            this.pnlContent.Controls.Add(this.pnlFooter);
            this.pnlContent.Location = new System.Drawing.Point(260, 70);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(785, 660);
            this.pnlContent.TabIndex = 11;
            // 
            // flowListings
            // 
            this.flowListings.AutoScroll = true;
            this.flowListings.BackColor = System.Drawing.Color.Transparent;
            this.flowListings.Controls.Add(this.pnlListingCard);
            this.flowListings.Controls.Add(this.panel1);
            this.flowListings.Location = new System.Drawing.Point(16, 230);
            this.flowListings.Name = "flowListings";
            this.flowListings.Size = new System.Drawing.Size(753, 400);
            this.flowListings.TabIndex = 5;
            // 
            // pnlListingCard
            // 
            this.pnlListingCard.BackColor = System.Drawing.Color.White;
            this.pnlListingCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListingCard.Controls.Add(this.btnListingView);
            this.pnlListingCard.Controls.Add(this.lblListingOwner);
            this.pnlListingCard.Controls.Add(this.lblListingPrice);
            this.pnlListingCard.Controls.Add(this.lblListingCategory);
            this.pnlListingCard.Controls.Add(this.lblListingTitle);
            this.pnlListingCard.Controls.Add(this.picListingImage);
            this.pnlListingCard.Location = new System.Drawing.Point(8, 8);
            this.pnlListingCard.Margin = new System.Windows.Forms.Padding(8);
            this.pnlListingCard.Name = "pnlListingCard";
            this.pnlListingCard.Size = new System.Drawing.Size(360, 240);
            this.pnlListingCard.TabIndex = 0;
            // 
            // btnListingView
            // 
            this.btnListingView.Location = new System.Drawing.Point(272, 196);
            this.btnListingView.Name = "btnListingView";
            this.btnListingView.Size = new System.Drawing.Size(80, 28);
            this.btnListingView.TabIndex = 5;
            this.btnListingView.Text = "View";
            this.btnListingView.UseVisualStyleBackColor = true;
            // 
            // lblListingOwner
            // 
            this.lblListingOwner.AutoSize = true;
            this.lblListingOwner.ForeColor = System.Drawing.Color.Gray;
            this.lblListingOwner.Location = new System.Drawing.Point(140, 200);
            this.lblListingOwner.Name = "lblListingOwner";
            this.lblListingOwner.Size = new System.Drawing.Size(69, 20);
            this.lblListingOwner.TabIndex = 4;
            this.lblListingOwner.Text = "By: Sarah";
            // 
            // lblListingPrice
            // 
            this.lblListingPrice.AutoSize = true;
            this.lblListingPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListingPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblListingPrice.Location = new System.Drawing.Point(8, 200);
            this.lblListingPrice.Name = "lblListingPrice";
            this.lblListingPrice.Size = new System.Drawing.Size(44, 25);
            this.lblListingPrice.TabIndex = 3;
            this.lblListingPrice.Text = "R50";
            // 
            // lblListingCategory
            // 
            this.lblListingCategory.AutoSize = true;
            this.lblListingCategory.ForeColor = System.Drawing.Color.Gray;
            this.lblListingCategory.Location = new System.Drawing.Point(8, 180);
            this.lblListingCategory.Name = "lblListingCategory";
            this.lblListingCategory.Size = new System.Drawing.Size(54, 20);
            this.lblListingCategory.TabIndex = 2;
            this.lblListingCategory.Text = "Baking";
            // 
            // lblListingTitle
            // 
            this.lblListingTitle.AutoSize = true;
            this.lblListingTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListingTitle.Location = new System.Drawing.Point(8, 148);
            this.lblListingTitle.Name = "lblListingTitle";
            this.lblListingTitle.Size = new System.Drawing.Size(200, 28);
            this.lblListingTitle.TabIndex = 1;
            this.lblListingTitle.Text = "Chocolate Cupcakes";
            // 
            // picListingImage
            // 
            this.picListingImage.Image = ((System.Drawing.Image)(resources.GetObject("picListingImage.Image")));
            this.picListingImage.Location = new System.Drawing.Point(8, 8);
            this.picListingImage.Name = "picListingImage";
            this.picListingImage.Size = new System.Drawing.Size(344, 132);
            this.picListingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picListingImage.TabIndex = 0;
            this.picListingImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(379, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // pnlFilterBar
            // 
            this.pnlFilterBar.Controls.Add(this.btnApplyFilter);
            this.pnlFilterBar.Controls.Add(this.cmbSortBy);
            this.pnlFilterBar.Controls.Add(this.txtKeyword);
            this.pnlFilterBar.Controls.Add(this.cmbCategory);
            this.pnlFilterBar.Location = new System.Drawing.Point(16, 170);
            this.pnlFilterBar.Name = "pnlFilterBar";
            this.pnlFilterBar.Size = new System.Drawing.Size(753, 48);
            this.pnlFilterBar.TabIndex = 4;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.Color.DarkGreen;
            this.btnApplyFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.Location = new System.Drawing.Point(660, 10);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(80, 30);
            this.btnApplyFilter.TabIndex = 3;
            this.btnApplyFilter.Text = "Apply";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Location = new System.Drawing.Point(530, 10);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(120, 31);
            this.cmbSortBy.TabIndex = 2;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.Location = new System.Drawing.Point(240, 10);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(280, 30);
            this.txtKeyword.TabIndex = 1;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(10, 10);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(220, 31);
            this.cmbCategory.TabIndex = 0;
            // 
            // pnlHero
            // 
            this.pnlHero.BackColor = System.Drawing.Color.White;
            this.pnlHero.Controls.Add(this.lblHeroSubtitle);
            this.pnlHero.Controls.Add(this.lblHeroTitle);
            this.pnlHero.Location = new System.Drawing.Point(16, 16);
            this.pnlHero.Name = "pnlHero";
            this.pnlHero.Size = new System.Drawing.Size(753, 140);
            this.pnlHero.TabIndex = 3;
            // 
            // lblHeroSubtitle
            // 
            this.lblHeroSubtitle.AutoSize = true;
            this.lblHeroSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeroSubtitle.Location = new System.Drawing.Point(20, 70);
            this.lblHeroSubtitle.Name = "lblHeroSubtitle";
            this.lblHeroSubtitle.Size = new System.Drawing.Size(518, 28);
            this.lblHeroSubtitle.TabIndex = 1;
            this.lblHeroSubtitle.Text = "Find tutors, bakers, designers and more made by students.";
            // 
            // lblHeroTitle
            // 
            this.lblHeroTitle.AutoSize = true;
            this.lblHeroTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroTitle.Location = new System.Drawing.Point(20, 16);
            this.lblHeroTitle.Name = "lblHeroTitle";
            this.lblHeroTitle.Size = new System.Drawing.Size(725, 54);
            this.lblHeroTitle.TabIndex = 0;
            this.lblHeroTitle.Text = "Buy/Sell within your res quick and easy";
            // 
            // lblFooterVersion
            // 
            this.lblFooterVersion.AutoSize = true;
            this.lblFooterVersion.Location = new System.Drawing.Point(1185, 737);
            this.lblFooterVersion.Name = "lblFooterVersion";
            this.lblFooterVersion.Size = new System.Drawing.Size(35, 20);
            this.lblFooterVersion.TabIndex = 2;
            this.lblFooterVersion.Text = "v0.1";
            // 
            // lblFooterLeft
            // 
            this.lblFooterLeft.AutoSize = true;
            this.lblFooterLeft.Location = new System.Drawing.Point(16, 737);
            this.lblFooterLeft.Name = "lblFooterLeft";
            this.lblFooterLeft.Size = new System.Drawing.Size(135, 20);
            this.lblFooterLeft.TabIndex = 1;
            this.lblFooterLeft.Text = "© Res Market 2025";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Location = new System.Drawing.Point(0, 730);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1345, 35);
            this.pnlFooter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(277, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME  TO RES MARKET";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1327, 898);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.btnNavLogout);
            this.Controls.Add(this.pnlLeftNav);
            this.Controls.Add(this.lblTopUserName);
            this.Controls.Add(this.picTopUser);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopUser)).EndInit();
            this.pnlLeftNav.ResumeLayout(false);
            this.pnlLeftNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSideUser)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.flowListings.ResumeLayout(false);
            this.pnlListingCard.ResumeLayout(false);
            this.pnlListingCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picListingImage)).EndInit();
            this.pnlFilterBar.ResumeLayout(false);
            this.pnlFilterBar.PerformLayout();
            this.pnlHero.ResumeLayout(false);
            this.pnlHero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picTopUser;
        private System.Windows.Forms.Label lblTopUserName;
        private System.Windows.Forms.Panel pnlLeftNav;
        private System.Windows.Forms.PictureBox picSideUser;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblSideUserName;
        private System.Windows.Forms.Button btnNavHome;
        private System.Windows.Forms.Button btnNavShop;
        private System.Windows.Forms.Button btnNavBrowse;
        private System.Windows.Forms.Button btnNavMessages;
        private System.Windows.Forms.Button btnNavProfile;
        private System.Windows.Forms.Button btnNavLogout;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblFooterVersion;
        private System.Windows.Forms.Label lblFooterLeft;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlHero;
        private System.Windows.Forms.Label lblHeroTitle;
        private System.Windows.Forms.Label lblHeroSubtitle;
        private System.Windows.Forms.Panel pnlFilterBar;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.ComboBox cmbSortBy;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.FlowLayoutPanel flowListings;
        private System.Windows.Forms.Panel pnlListingCard;
        private System.Windows.Forms.Label lblListingCategory;
        private System.Windows.Forms.Label lblListingTitle;
        private System.Windows.Forms.PictureBox picListingImage;
        private System.Windows.Forms.Button btnListingView;
        private System.Windows.Forms.Label lblListingOwner;
        private System.Windows.Forms.Label lblListingPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}