using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace resMarket
{
    public partial class frmViewItem : Form
    {
        private int currentUserId;
        private int itemId;
        private int sellerId;

        public frmViewItem(int userId, int itemId, int sellerId,
                           string itemName, string description, decimal price,
                           string sellerName, string imagePath)
        {
            InitializeComponent();

            this.currentUserId = userId;
            this.itemId = itemId;
            this.sellerId = sellerId;

            lblItemName.Text = itemName;
            lblDescription.Text = description;
            lblPrice.Text = "R" + price.ToString("0.00");
            lblSeller.Text = "Seller: " + sellerName;

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                picItem.Image = Image.FromFile(imagePath);
                picItem.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                picItem.Image = null;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void btnMessageSeller_Click(object sender, EventArgs e)
{
    frmMain mainForm = this.Owner as frmMain;
    if (mainForm != null)
    {
        UC_Messages chatControl = new UC_Messages(currentUserId, sellerId);
        mainForm.LoadContent(chatControl);
        this.Close();
    }
}

        private void frmViewItem_Load(object sender, EventArgs e)
        {

        }
    }
}