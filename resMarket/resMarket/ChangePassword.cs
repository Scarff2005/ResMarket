using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace resMarket
{
    public partial class ChangePassword : Form
    {
        private int currentUserId = 0;
        private string connStr = "Server=LILLY\\SQLEXPRESS;Database=resMarketDB;Trusted_Connection=True;";


        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(int userId) : this()
        {
            currentUserId = userId;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
        
            txtCurrentPass.UseSystemPasswordChar = true;
            txtNewPass.UseSystemPasswordChar = true;
            txtConfirmPass.UseSystemPasswordChar = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string current = txtCurrentPass.Text ?? "";
            string newPass = txtNewPass.Text ?? "";
            string confirm = txtConfirmPass.Text ?? "";

            if (string.IsNullOrWhiteSpace(current) ||
                string.IsNullOrWhiteSpace(newPass) ||
                string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (newPass.Length < 6 ||
                !newPass.Any(char.IsUpper) ||
                !newPass.Any(char.IsDigit) ||
                !newPass.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Password must be at least 6 characters, include an uppercase letter, a number and a special character.");
                return;
            }

            if (newPass != confirm)
            {
                MessageBox.Show("New password and confirmation do not match.");
                return;
            }

            if (currentUserId <= 0)
            {
                MessageBox.Show("User ID not available. Please re-login and try again.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                   
                    string checkSql = "SELECT PasswordHash FROM Users WHERE UserID = @ID";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ID", currentUserId);
                        var dbPassObj = checkCmd.ExecuteScalar();

                        if (dbPassObj == null)
                        {
                            MessageBox.Show("User not found.");
                            return;
                        }

                        string dbPass = dbPassObj.ToString();

                      
                        if (dbPass != current)
                        {
                            MessageBox.Show("Current password is incorrect.");
                            return;
                        }
                    }

                  
                    string updateSql = "UPDATE Users SET PasswordHash = @NewPass WHERE UserID = @ID";
                    using (SqlCommand updateCmd = new SqlCommand(updateSql, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@NewPass", newPass);
                        updateCmd.Parameters.AddWithValue("@ID", currentUserId);

                        int rows = updateCmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Password updated successfully.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update password.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
          
        }
    }
}