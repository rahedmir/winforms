using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zscaler
{
    public partial class zscaler : Form
    {
        public zscaler()
        {
            InitializeComponent();
        }


        int tbSentCount = 50;
        int tbReceivedCount = 200;

        static void panelSelection(Panel InternetSecurity, Panel DigitalExperience, Panel Notification, Panel More)
        {
            InternetSecurity.Visible = false;
            DigitalExperience.Visible = false;
            Notification.Visible = false;
            More.Visible = false;
        }

        /*-----------------------------------------------------------------------------------------------------------------*/

        private void zscaler_Load(object sender, EventArgs e)
        {
            panelSelection(panelInternetSecurity, panelDigitalExperience, panelNotification, panelMore);
            panelInternetSecurity.Visible = true;

        }

        /*-----------------------------------------------------------------------------------------------------------------*/

        private void btnInternetSecurity_MouseHover(object sender, EventArgs e)
        {
            lblInternetSecurity.ForeColor = Color.FromArgb(35, 107, 245);
        }

        private void btnDigitalExperience_MouseHover(object sender, EventArgs e)
        {
            lblDigitalExperience.ForeColor = Color.FromArgb(35, 107, 245);
        }

        private void btnNotifications_MouseHover(object sender, EventArgs e)
        {
            lblNotifications.ForeColor = Color.FromArgb(35, 107, 245);
        }

        private void btnMore_MouseHover(object sender, EventArgs e)
        {
            lblMore.ForeColor = Color.FromArgb(35, 107, 245);
        }



        private void btnInternetSecurity_MouseLeave(object sender, EventArgs e)
        {
            lblInternetSecurity.ForeColor = Color.FromArgb(65, 70, 66);
        }

        private void btnDigitalExperience_MouseLeave(object sender, EventArgs e)
        {
            lblDigitalExperience.ForeColor = Color.FromArgb(65, 70, 66);
        }

        private void btnNotifications_MouseLeave(object sender, EventArgs e)
        {
            lblNotifications.ForeColor = Color.FromArgb(65, 70, 66);
        }

        private void btnMore_MouseLeave(object sender, EventArgs e)
        {
            lblMore.ForeColor = Color.FromArgb(65, 70, 66);
        }

        /*-----------------------------------------------------------------------------------------------------------------*/

        private void btnInternetSecurity_Click(object sender, EventArgs e)
        {
            panelSelection(panelInternetSecurity, panelDigitalExperience, panelNotification, panelMore);
            panelInternetSecurity.Visible = true;
        }

        private void btnDigitalExperience_Click(object sender, EventArgs e)
        {
            panelSelection(panelInternetSecurity, panelDigitalExperience, panelNotification, panelMore);
            panelDigitalExperience.Visible = true;
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            panelSelection(panelInternetSecurity, panelDigitalExperience, panelNotification, panelMore);
            panelNotification.Visible = true;
            panelNotificationMessage.Visible = true;
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            panelSelection(panelInternetSecurity, panelDigitalExperience, panelNotification, panelMore);
            panelMore.Visible = true;
        }

        /*-----------------------------------------------------------------------------------------------------------------*/


        //Internet Security

        private void lblIntrTurnOnOff_Click(object sender, EventArgs e)
        {
            if (lblIntrTurnOnOff.Text == "TURN OFF")
            {
                lblIntrOnOffStatus.Text = "OFF";
                lblIntrOnOffStatus.ForeColor = Color.FromArgb(230, 17, 33);

                lblIntrTurnOnOff.Text = "TURN ON";
                lblIntrTurnOnOff.ForeColor = Color.FromArgb(65, 70, 66);

                imgIntrOn.Visible = false;
                imgIntrOff.Visible = true;
            } 
            else if (lblIntrTurnOnOff.Text == "TURN ON")
            {
                lblIntrOnOffStatus.Text = "ON";
                lblIntrOnOffStatus.ForeColor = Color.FromArgb(0, 197, 0);

                lblIntrTurnOnOff.Text = "TURN OFF";
                lblIntrTurnOnOff.ForeColor = Color.FromArgb(35, 107, 245);

                imgIntrOn.Visible = true;
                imgIntrOff.Visible = false;
            }
        }


        private void timerInternetSecurity_Tick(object sender, EventArgs e)
        {
            lblIntrDateTime.Text = DateTime.Now.ToString("ddd") + ", " + DateTime.Now.ToString("U");
        }

        private void timerTotalBytesSent_Tick(object sender, EventArgs e)
        {
            tbSentCount++;
            lblTotalBytesSent.Text = tbSentCount.ToString() + " KB";
        }

        private void timerTotalBytesReceived_Tick(object sender, EventArgs e)
        {
            tbReceivedCount++;
            lblTotalBytesReceived.Text = tbReceivedCount.ToString() + " KB";
        }

        /*-----------------------------------------------------------------------------------------------------------------*/


        //Digital Experiance

        private void lblDigtTurnOnOff_Click(object sender, EventArgs e)
        {
            if (lblDigtTurnOnOff.Text == "TURN OFF")
            {
                lblDigtOnOffStatus.Text = "OFF";
                lblDigtOnOffStatus.ForeColor = Color.FromArgb(230, 17, 33);

                lblDigtTurnOnOff.Text = "TURN ON";
                lblDigtTurnOnOff.ForeColor = Color.FromArgb(65, 70, 66);

                imgDigtOn.Visible = false;
                imgDigtOff.Visible = true;

                lblAuthentication.Text = "Unauthenticated";
                lblAuthentication.ForeColor = Color.FromArgb(230, 17, 33);
            }
            else if (lblDigtTurnOnOff.Text == "TURN ON")
            {
                lblDigtOnOffStatus.Text = "ON";
                lblDigtOnOffStatus.ForeColor = Color.FromArgb(0, 197, 0);

                lblDigtTurnOnOff.Text = "TURN OFF";
                lblDigtTurnOnOff.ForeColor = Color.FromArgb(35, 107, 245);

                imgDigtOn.Visible = true;
                imgDigtOff.Visible = false;

                lblAuthentication.Text = "Authenticated";
                lblAuthentication.ForeColor = Color.FromArgb(0, 197, 0);
            }
        }


        private void timerDigitalExperience_Tick(object sender, EventArgs e)
        {
            lblDigtDateTime.Text = DateTime.Now.ToString("ddd") + ", " + DateTime.Now.ToString("U");
        }

        /*-----------------------------------------------------------------------------------------------------------------*/


        //Notification

        private void timerDate_Tick(object sender, EventArgs e)
        {
            lblDate1.Text = DateTime.Now.ToString("MMM d") + ", " + DateTime.Now.ToString("yyyy");
            lblDate2.Text = DateTime.Now.ToString("MMM d") + ", " + DateTime.Now.ToString("yyyy");
            lblDate3.Text = DateTime.Now.ToString("MMM d") + ", " + DateTime.Now.ToString("yyyy");
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime1.Text = DateTime.Now.AddMinutes(-5).ToString("hh:mm tt");
            lblTime2.Text = DateTime.Now.AddMinutes(-10).ToString("hh:mm tt");
            lblTime3.Text = DateTime.Now.AddMinutes(-15).ToString("hh:mm tt");
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            panelNotificationMessage.Visible = false;
        }

       
    }
}
