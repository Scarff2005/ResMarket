using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace resMarket
{
    public partial class UC_Browse : UserControl
    {
        private string connStr = "Server=LILLY\\SQLEXPRESS;Database=resMarketDB;Trusted_Connection=True;";
        private int currentUserId = 0;

        public UC_Browse(int userId = 0)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void UC_Browse_Load(object sender, EventArgs e)
        {
            LoadMarketplaceItems();
        }

        private void LoadMarketplaceItems(string keyword = "")
        {
            flowListings.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = @"SELECT i.ItemID, i.ItemName, i.Price, i.Description, i.ImagePath, 
                                          u.UserID AS SellerID, u.FullName
                                   FROM Items i
                                   INNER JOIN Users u ON i.UserID = u.UserID";

                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        sql += " WHERE i.ItemName LIKE @kw OR i.Description LIKE @kw";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(keyword))
                        {
                            cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                        }

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            int itemId = Convert.ToInt32(reader["ItemID"]);
                            int sellerId = Convert.ToInt32(reader["SellerID"]);
                            string itemName = reader["ItemName"].ToString();
                            string description = reader["Description"].ToString();
                            string owner = reader["FullName"].ToString();
                            decimal price = Convert.ToDecimal(reader["Price"]);
                            string imagePath = reader["ImagePath"].ToString();

                            Panel card = new Panel();
                            card.Width = 360;
                            card.Height = 240;
                            card.BackColor = Color.White;
                            card.BorderStyle = BorderStyle.FixedSingle;
                            card.Margin = new Padding(10);

                            PictureBox pic = new PictureBox();
                            pic.Width = 344;
                            pic.Height = 132;
                            pic.Top = 8;
                            pic.Left = 8;
                            pic.SizeMode = PictureBoxSizeMode.Zoom;
                            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                            {
                                pic.Image = Image.FromFile(imagePath);
                            }

                            Label lblTitle = new Label();
                            lblTitle.Text = itemName;
                            lblTitle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                            lblTitle.Top = 148;
                            lblTitle.Left = 8;
                            lblTitle.AutoSize = true;

                            Label lblDesc = new Label();
                            lblDesc.Text = description;
                            lblDesc.Top = 178;
                            lblDesc.Left = 8;
                            lblDesc.Width = 200;

                            Label lblPrice = new Label();
                            lblPrice.Text = "R" + price.ToString("0.00");
                            lblPrice.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                            lblPrice.ForeColor = Color.DarkGreen;
                            lblPrice.Top = 200;
                            lblPrice.Left = 8;

                            Label lblOwner = new Label();
                            lblOwner.Text = "By: " + owner;
                            lblOwner.ForeColor = Color.Gray;
                            lblOwner.Top = 200;
                            lblOwner.Left = 120;
                            lblOwner.AutoSize = true;

                            Button btnView = new Button();
                            btnView.Text = "View";
                            btnView.Width = 80;
                            btnView.Height = 28;
                            btnView.Top = 196;
                            btnView.Left = 260;
                            btnView.Click += (s, e) =>
                            {
                                frmViewItem viewForm = new frmViewItem(
                                    currentUserId,
                                    itemId,
                                    sellerId,
                                    itemName,
                                    description,
                                    price,
                                    owner,
                                    imagePath
                                );
                                viewForm.Owner = FindForm();
                                viewForm.ShowDialog();
                            };

                            card.Controls.Add(pic);
                            card.Controls.Add(lblTitle);
                            card.Controls.Add(lblDesc);
                            card.Controls.Add(lblPrice);
                            card.Controls.Add(lblOwner);
                            card.Controls.Add(btnView);

                            flowListings.Controls.Add(card);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            LoadMarketplaceItems(keyword);
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }
    }
}