using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Expense_Tracker
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPanel.Visible = false;
            LoginPanel.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPanel.Visible = false;
            RegisterPanel.Visible = true;
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string name = nameRegBox.Text;
            string email = emailRegBox.Text;
            string password = passRegBox.Text;
            string confirmPass = confirmPassRegBox.Text;
            Guid userId = Guid.NewGuid();


            if (email == null || name == null || password == null || confirmPass == null)
            {
                MessageBox.Show("PLease input in the feilds");
            }
            else if( password != confirmPass)
            {
                MessageBox.Show("Passwords do not match");
            }
            else
            {
               User user = new User(name, email, password, userId);
               bool isRegistered = user.register();

                if (isRegistered)
                {
                    LoginPanel.Visible = true;
                    RegisterPanel.Visible = false;
                    MessageBox.Show("Registerd succesfully");
                }
            }
        }

        private void passwordLoginBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void Login()
        {
            string email = emailLoginBox.Text;
            string password = passwordLoginBox.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please input all fields.");
                return;
            }

            User user = new User(email, password);

            (bool isLogged, string userName, string userEmail, string userPassword, string userId) = user.Login();

            if (isLogged)
            {
                Console.WriteLine($"Login successful!\nName: {userName}\nEmail: {userEmail}\nUser ID: {userId}");

                this.Hide();
                Dashboard dashboard = new Dashboard(userName, userEmail, userPassword, userId);
                dashboard.Show();
                MessageBox.Show("Login Successful");
            }
            else
            {
                Console.WriteLine("Login failed. Please check your credentials.");
                MessageBox.Show("Login failed. Please check your credentials.");
            }
        }

    }
}
