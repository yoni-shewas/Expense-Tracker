using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Expense_Tracker
{
    public partial class Dashboard : Form
    {
        private string email;
        private string password;
        private string name;
        private string id;
        public Dashboard(string userName, string userEmail, string userPassword, string userId)
        {
            InitializeComponent();
            email = userName;
            password = userPassword;
            name = userEmail;
            id = userId;

            UserNameLabel.Text = userName;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

      
        private void HomeNav_Click(object sender, EventArgs e)
        {
            ReportPanel.Hide();
            ProfilePanel.Hide();
            HomePanel.Show();

            HomeNav.BackColor = SystemColors.MenuHighlight;
            ProfileNav.BackColor = SystemColors.GradientInactiveCaption;
            ReportNav.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void ProfileNav_Click(object sender, EventArgs e)
        {
            ReportPanel.Hide();
            ProfilePanel.Show();
            HomePanel.Hide();

            HomeNav.BackColor = SystemColors.GradientInactiveCaption;
            ProfileNav.BackColor = SystemColors.MenuHighlight;
            ReportNav.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void ReportNav_Click(object sender, EventArgs e)
        {
            ReportPanel.Show();
            ProfilePanel.Hide();
            HomePanel.Hide();

            HomeNav.BackColor = SystemColors.GradientInactiveCaption;
            ProfileNav.BackColor = SystemColors.GradientInactiveCaption;
            ReportNav.BackColor = SystemColors.MenuHighlight;
        }

        private void LogoutLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            email = "";
            password = "";
            name = "";
            id = "";
            this.Hide();
            LoginForm loginPage = new LoginForm();
            loginPage.Show();

        }
    }
}
