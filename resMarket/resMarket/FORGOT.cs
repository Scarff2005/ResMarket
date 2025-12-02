using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resMarket
{
    public partial class FORGOT : Form
    {
        public FORGOT()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If an account with that email exists, a password reset link has been sent.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FORGOT_Load(object sender, EventArgs e)
        {

        }
    }
}
