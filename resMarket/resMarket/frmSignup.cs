using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace resMarket
{
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
   
            txtPassword.UseSystemPasswordChar = true;
            txtConfirm.UseSystemPasswordChar = true;
        }

        private void chkShowPasswords_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPasswords.Checked;
            txtPassword.UseSystemPasswordChar = !show;
            txtConfirm.UseSystemPasswordChar = !show;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateFullName() && ValidateResidence() && ValidateEmail() && ValidatePassword() && ValidateConfirmPassword())
            {
                try
                {
                    string connStr = "Server=LILLY\\SQLEXPRESS;Database=resMarketDB;Trusted_Connection=True;";

                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        string query = "INSERT INTO Users (FullName, Residence, Email, PasswordHash) VALUES (@FullName, @Residence, @Email, @Password)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                            cmd.Parameters.AddWithValue("@Residence", txtRes.Text);
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Account created successfully!");
                    var login = new frmLogin();
                    login.Show();
                    this.Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        MessageBox.Show("This email is already registered.");
                    else
                        MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
        }

        private bool ValidateFullName()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full name cannot be empty.");
                return false;
            }
            if (txtFullName.Text.Length < 3)
            {
                MessageBox.Show("Full name must be at least 3 characters.");
                return false;
            }
            return true;
        }

        private bool ValidateResidence()
        {
            if (string.IsNullOrWhiteSpace(txtRes.Text))
            {
                MessageBox.Show("Residence cannot be empty.");
                return false;
            }
            return true;
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

        private bool ValidateConfirmPassword()
        {
            if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }
            return true;
        }
    }
}