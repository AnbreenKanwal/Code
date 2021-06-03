using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonDashboard.Height;
            panelLeft.Top = buttonDashboard.Top;
        }

        private void buttonTollPlazaAccount_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTollPlazaAccount.Height;
            panelLeft.Top = buttonTollPlazaAccount.Top;
        }

        private void buttonSignalTimerSettings_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonSignalTimerSettings.Height;
            panelLeft.Top = buttonSignalTimerSettings.Top;
        }

        private void buttonSurvey_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonSurvey.Height;
            panelLeft.Top = buttonSurvey.Top;
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonReports.Height;
            panelLeft.Top = buttonReports.Top;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonProfile.Height;
            panelLeft.Top = buttonProfile.Top;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonLogout.Height;
            panelLeft.Top = buttonLogout.Top;
        }
    }
}
