using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace resMarket
{
    public partial class UC_Shop : UserControl
    {
        private string connStr = "Server=LILLY\\SQLEXPRESS;Database=resMarketDB;Trusted_Connection=True;";
        private int currentUserId;
        private int editingItemId = 0; 

        public UC_Shop(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void UC_Shop_Load(object sender, EventArgs e)
        {
            dgvItems.AutoGenerateColumns = false;
            dgvItems.Columns.Clear();

     
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.HeaderText = "ID";
            colId.DataPropertyName = "ItemID";
            colId.Name = "ItemID";
            colId.Visible = false;
            dgvItems.Columns.Add(colId);

            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.HeaderText = "Item Name";
            colName.DataPropertyName = "ItemName";
            colName.Width = 200;
            dgvItems.Columns.Add(colName);

            DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn();
            colPrice.HeaderText = "Price";
            colPrice.DataPropertyName = "Price";
            colPrice.Width = 100;
            dgvItems.Columns.Add(colPrice);

            DataGridViewTextBoxColumn colDesc = new DataGridViewTextBoxColumn();
            colDesc.HeaderText = "Description";
            colDesc.DataPropertyName = "Description";
            colDesc.Width = 250;
            dgvItems.Columns.Add(colDesc);

            DataGridViewButtonColumn editCol = new DataGridViewButtonColumn();
            editCol.Name = "Edit";
            editCol.HeaderText = "Edit";
            editCol.Text = "Edit";
            editCol.UseColumnTextForButtonValue = true;
            editCol.Width = 70;
            dgvItems.Columns.Add(editCol);

            DataGridViewButtonColumn deleteCol = new DataGridViewButtonColumn();
            deleteCol.Name = "Delete";
            deleteCol.HeaderText = "Delete";
            deleteCol.Text = "Delete";
            deleteCol.UseColumnTextForButtonValue = true;
            deleteCol.Width = 70;
            dgvItems.Columns.Add(deleteCol);

            LoadItems();
        }

        private void LoadItems()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT ItemID, ItemName, Price, Description FROM Items WHERE UserID = @UserID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@UserID", currentUserId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvItems.DataSource = dt;
            }
        }

        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picItem.Image = Image.FromFile(ofd.FileName);
                picItem.Tag = ofd.FileName; 
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text) ||
                string.IsNullOrWhiteSpace(txtItemPrice.Text) ||
                string.IsNullOrWhiteSpace(txtItemDesc.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(txtItemPrice.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal price))
            {
                MessageBox.Show("Price must be a valid number (e.g. 99.99).");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query;

                if (editingItemId == 0)
                {
                   
                    query = "INSERT INTO Items (UserID, ItemName, Price, Description, ImagePath) VALUES (@UserID, @Name, @Price, @Desc, @Image)";
                }
                else
                {
  
                    query = "UPDATE Items SET ItemName = @Name, Price = @Price, Description = @Desc, ImagePath = @Image WHERE ItemID = @ID AND UserID = @UserID";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", currentUserId);
                cmd.Parameters.AddWithValue("@Name", txtItemName.Text);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Desc", txtItemDesc.Text);
                cmd.Parameters.AddWithValue("@Image", picItem.Tag ?? DBNull.Value);

                if (editingItemId != 0)
                    cmd.Parameters.AddWithValue("@ID", editingItemId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            if (editingItemId == 0)
                MessageBox.Show("Item added successfully!");
            else
                MessageBox.Show("Item updated successfully!");

            editingItemId = 0; 
            LoadItems();

            txtItemName.Clear();
            txtItemPrice.Clear();
            txtItemDesc.Clear();
            picItem.Image = null;
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int itemId = Convert.ToInt32(dgvItems.Rows[e.RowIndex].Cells["ItemID"].Value);

                if (dgvItems.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete this item?",
                                                      "Confirm Delete",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection(connStr))
                        {
                            string query = "DELETE FROM Items WHERE ItemID = @ID AND UserID = @UserID";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@ID", itemId);
                            cmd.Parameters.AddWithValue("@UserID", currentUserId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }

                        LoadItems();
                    }
                }
                else if (dgvItems.Columns[e.ColumnIndex].Name == "Edit")
                {
                  
                    txtItemName.Text = dgvItems.Rows[e.RowIndex].Cells["ItemName"].Value.ToString();
                    txtItemPrice.Text = dgvItems.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                    txtItemDesc.Text = dgvItems.Rows[e.RowIndex].Cells["Description"].Value.ToString();

               
                    editingItemId = itemId;
                }
            }
        }
    }
}