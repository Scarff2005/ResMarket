using System;
using System.Windows.Forms;

namespace resMarket
{
    public partial class frmMain : Form
    {
        private int loggedInUserId;
        private string loggedInName;
        private string loggedInEmail;


        public frmMain(int userId, string fullName, string email)
        {
            InitializeComponent();
            loggedInUserId = userId;
            loggedInName = fullName;
            loggedInEmail = email;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblTopUserName.Text = $"Welcome, {loggedInName}";
            lblSideUserName.Text = loggedInEmail;

            if (!DesignMode)
            {
          
                LoadContent(new UC_Home());
            }
        }

        public void LoadContent(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void btnNavHome_Click(object sender, EventArgs e)
        {
            LoadContent(new UC_Home( loggedInUserId));
        }

        private void btnNavBrowse_Click(object sender, EventArgs e)
        {
            LoadContent(new UC_Browse(loggedInUserId));
        }

        private void btnNavShop_Click(object sender, EventArgs e)
        {
            // Pass logged in user id to shop UC
            UC_Shop shopControl = new UC_Shop(loggedInUserId);
            LoadContent(shopControl);
        }

        private void btnNavMessages_Click(object sender, EventArgs e)
        {
            // Pass user id to messages UC
            LoadContent(new UC_Messages(loggedInUserId));
        }

        private void btnNavProfile_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
                LoadContent(new UC_Profile(loggedInUserId));
        }

        private void btnNavLogout_Click(object sender, EventArgs e)
        {
            var login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void btnNavMessages_Click_1(object sender, EventArgs e)
        {
            LoadContent(new UC_Messages(loggedInUserId));
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {

        }
    }
}