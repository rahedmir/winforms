using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_form
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == " Username")
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = " Username";
            }
        }



        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == " Password")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = " Password";
                txtPassword.PasswordChar = '\0';
            }
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
           if (txtUsername.Text == "admin" && txtPassword.Text == "password")
            {
                MessageBox.Show("Login Successful.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else
            {
                MessageBox.Show("Login Failed, incorrect Username or Password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void lblCreateAccount_MouseHover(object sender, EventArgs e)
        {
            lblCreateAccount.Font = new Font (lblCreateAccount.Font.Name, 10, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            lblCreateAccount.Font = new Font(lblCreateAccount.Font.Name, 10);
        }



        private void frmlogin_Load(object sender, EventArgs e)
        {
            lblCreateAccount.Font = new Font(lblCreateAccount.Font.Name, 10);
        }

    }
}
