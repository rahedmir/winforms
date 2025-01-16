using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anydesk
{
    public partial class anydesk : Form
    {
        public anydesk()
        {
            InitializeComponent();
        }



        private void timer_Tick(object sender, EventArgs e)
        {
            lblConnectionTime.Text = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
        }




        private void lblMore_MouseHover(object sender, EventArgs e)
        {
            lblMore.Font = new Font(lblMore.Font.Name, 14, FontStyle.Underline);
        }

        private void lblMore_MouseLeave(object sender, EventArgs e)
        {
            lblMore.Font = new Font(lblMore.Font.Name, 14);
        }



        private void btnDisconnect_Click(object sender, EventArgs e)
        {
           DialogResult msg = MessageBox.Show("Do you want to disconnect?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { }
        }




        private void txtMessage_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text == "Message")
            {
                txtMessage.Text = "";
            }
        }

        private void txtMessage_Leave(object sender, EventArgs e)
        {
            if (txtMessage.Text == "")
            {
                txtMessage.Text = "Message";
            }
        }

        
    }
}
