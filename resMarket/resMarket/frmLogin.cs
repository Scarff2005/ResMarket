using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace resMarket
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateEmail() && ValidatePassword())
            {
                try
                {
                    string connStr = "Server=LILLY\\SQLEXPRESS;Database=resMarketDB;Trusted_Connection=True;";

                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                     
                        string query = "SELECT UserID, FullName, Email FROM Users WHERE Email = @Email AND PasswordHash = @Password";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.Read())
                            {
                         
                                int userId = Convert.ToInt32(reader["UserID"]);
                                string fullName = reader["FullName"].ToString();
                                string email = reader["Email"].ToString();

                                var main = new frmMain(userId, fullName, email);
                                main.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.");
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;
            txtPassword.UseSystemPasswordChar = !show;
        }

        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var create = new frmSignup();
            create.Show();
            this.Hide();
        }

        private bool ValidateEmail()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email cannot be empty.");
                return false;
            }
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Invalid email format.");
                return false;
            }
            return true;
        }

        private bool ValidatePassword()
        {
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password cannot be empty.");
                return false;
            }
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return false;
            }
            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Password must contain at least one uppercase letter.");
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Password must contain at least one number.");
                return false;
            }
            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Password must contain at least one special symbol.");
                return false;
            }
            return true;
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var forgot = new FORGOT();
            forgot.Show();
            
        }
    }
}