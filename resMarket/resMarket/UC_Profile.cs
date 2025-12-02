using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace resMarket
{
    public partial class UC_Profile : UserControl
    {
        private int currentUserId = 0;
        private bool isEditing = false;
        private string connStr = "Server=LILLY\\SQLEXPRESS;Database=resMarketDB;Trusted_Connection=True;";

       
        public UC_Profile()
        {
            InitializeComponent();
        }

      
        public UC_Profile(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {
            try
            {
                string connStr = "Server=LILLY\\SQLEXPRESS;Database=resMarketDB;Trusted_Connection=True;";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "SELECT FullName, Email, Residence, ProfilePic FROM Users WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", currentUserId);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtFullName.Text = reader["FullName"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtResidence.Text = reader["Residence"].ToString();

                            if (reader["ProfilePic"] != DBNull.Value)
                            {
                                string path = reader["ProfilePic"].ToString();
                                if (System.IO.File.Exists(path))
                                {
                                    picProfile.Image = Image.FromFile(path);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }

            LockFields();

            if (currentUserId > 0)
            {
                LoadProfileFromDb();
            }

        }

        private void LoadProfileFromDb()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = "SELECT FullName, Residence, Email FROM Users WHERE UserID = @ID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", currentUserId);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFullName.Text = reader["FullName"]?.ToString();
                                txtEmail.Text = reader["Email"]?.ToString();
                                txtResidence.Text = reader["Residence"]?.ToString();

                            }
                            else
                            {
                            
                                txtFullName.Text = "";
                                txtEmail.Text = "";
                                txtResidence.Text = "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void LockFields()
        {
            txtFullName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtResidence.ReadOnly = true;
            txtBlock.ReadOnly = true;
            btnEditProfile.Text = "Edit Profile";
            isEditing = false;
        }

        private void UnlockFields()
        {
            txtFullName.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtResidence.ReadOnly = false;
            txtBlock.ReadOnly = false; 
            btnEditProfile.Text = "Save";
            isEditing = true;
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                UnlockFields();
            }
            else
            {
              
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Full name cannot be empty.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Email cannot be empty.");
                    return;
                }

                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        string sql = "UPDATE Users SET FullName = @FullName, Residence = @Residence, Email = @Email WHERE UserID = @ID";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                            cmd.Parameters.AddWithValue("@Residence", txtResidence.Text.Trim());
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@ID", currentUserId);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Profile updated successfully.");
                    LockFields();
                   
                    LoadProfileFromDb();
                }
                catch (SqlException ex)
                {
                   
                    if (ex.Number == 2627)
                        MessageBox.Show("That email address is already in use by another account.");
                    else
                        MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving profile: " + ex.Message);
                }
            }
        }

        private void btnChangePic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select profile picture";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                 
                        picProfile.Image = Image.FromFile(ofd.FileName);

                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not load image: " + ex.Message);
                    }
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var cp = new ChangePassword(currentUserId); 
            cp.ShowDialog();
        }

        private void btnChangePassword_Click_1(object sender, EventArgs e)
        {
            var cp = new ChangePassword(currentUserId);
            cp.ShowDialog();
        }

        private void btnChangePic_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = ofd.FileName;

                try
                {
                    string connStr = "Server=LILLY\\SQLEXPRESS;Database=resMarketDB;Trusted_Connection=True;";
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        string query = "UPDATE Users SET ProfilePic = @ProfilePic WHERE UserID = @UserID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ProfilePic", selectedPath);
                            cmd.Parameters.AddWithValue("@UserID", currentUserId);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                
                    picProfile.Image = Image.FromFile(selectedPath);
                    MessageBox.Show("Profile picture updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating picture: " + ex.Message);
                }
            }
        }

        private void btnEditProfile_Click_1(object sender, EventArgs e)
        {
            if (!isEditing)
            {
               
                txtFullName.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtResidence.ReadOnly = false;
                txtBlock.ReadOnly = false; 

                btnEditProfile.Text = "Save";
                isEditing = true;
            }
            else
            {
            
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Full name cannot be empty.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Email cannot be empty.");
                    return;
                }

                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        string sql = "UPDATE Users SET FullName = @FullName, Residence = @Residence, Email = @Email WHERE UserID = @ID";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                            cmd.Parameters.AddWithValue("@Residence", txtResidence.Text.Trim());
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@ID", currentUserId);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Profile updated successfully!");

                    txtFullName.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtResidence.ReadOnly = true;
                    txtBlock.ReadOnly = true;

                    btnEditProfile.Text = "Edit Profile";
                    isEditing = false;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) 
                        MessageBox.Show("That email address is already in use.");
                    else
                        MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}