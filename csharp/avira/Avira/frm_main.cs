using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avira
{

    public partial class frm_main : Form
    {
        public void status_click()
        {
            gunaActive1.Visible = false;
            gunaActive2.Visible = false;
            gunaActive3.Visible = false;
            gunaActive4.Visible = false;

            gunaButtonStatus.BaseColor = Color.FromArgb(32, 42, 47);
            gunaButtonSecurity.BaseColor = Color.FromArgb(32, 42, 47);
            gunaButtonPrivacy.BaseColor = Color.FromArgb(32, 42, 47);
            gunaButtonPerformance.BaseColor = Color.FromArgb(32, 42, 47);

        }

        public void buttonStatus()
        {
            gunaPanelStatus.Controls.Clear();

            frm_status statusForm = new frm_status();
            statusForm.TopLevel = false;
            this.gunaPanelStatus.Controls.Add(statusForm);
            statusForm.Show();
        }

        public void buttonSecurity()
        {
            gunaPanelStatus.Controls.Clear();

            frm_security securityForm = new frm_security();
            securityForm.TopLevel = false;
            this.gunaPanelStatus.Controls.Add(securityForm);
            securityForm.Show();
        }

        public void buttonPrivacy()
        {
            gunaPanelStatus.Controls.Clear();

            frm_privacy privacyForm = new frm_privacy();
            privacyForm.TopLevel = false;
            this.gunaPanelStatus.Controls.Add(privacyForm);
            privacyForm.Show();
        }

        public void buttonPerformance()
        {
            gunaPanelStatus.Controls.Clear();

            frm_performance performanceForm = new frm_performance();
            performanceForm.TopLevel = false;
            this.gunaPanelStatus.Controls.Add(performanceForm);
            performanceForm.Show();
        }

        public frm_main()
        {
            InitializeComponent();
        }


        private void avira_Load(object sender, EventArgs e)
        {
            status_click();
            gunaActive1.Visible = true;
            gunaButtonStatus.BaseColor = Color.FromArgb(47, 55, 63);

            buttonStatus();
        }

        private void gunaButtonStatus_Click(object sender, EventArgs e)
        {
            status_click();
            gunaActive1.Visible = true;
            gunaButtonStatus.BaseColor = Color.FromArgb(47, 55, 63);

            buttonStatus();
        }

        private void gunaButtonSecurity_Click(object sender, EventArgs e)
        {
            status_click();
            gunaActive2.Visible = true;
            gunaButtonSecurity.BaseColor = Color.FromArgb(47, 55, 63);

            buttonSecurity();
        }

        private void gunaButtonPrivacy_Click(object sender, EventArgs e)
        {
            status_click();
            gunaActive3.Visible = true;
            gunaButtonPrivacy.BaseColor = Color.FromArgb(47, 55, 63);

            buttonPrivacy();
        }

        private void gunaButtonPerformance_Click(object sender, EventArgs e)
        {
            status_click();
            gunaActive4.Visible = true;
            gunaButtonPerformance.BaseColor = Color.FromArgb(47, 55, 63);

            buttonPerformance();
        }

        
    }

 
}
 