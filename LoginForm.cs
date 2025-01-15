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
            string email = emailLoginBox.Text;
            string password = passwordLoginBox.Text;

            if (email == null || password == null) 
            {
                MessageBox.Show("PLease input in the feilds");
            }
            else
            {
                SqlConnection DB = new DBConnection().openConnection();
                SqlDataReader reader = null;

                try
                {
                    string query = "select * from [User] where email = @email and password = @password";
                    SqlCommand cmd = new SqlCommand(query, DB);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    reader = cmd.ExecuteReader();

                    if (reader != null)
                    {
                        if (reader.Read())
                        {
                            this.Hide();
                            string userEmail = reader["email"].ToString();
                            string userName = reader["name"].ToString();
                            string userPassword = reader["password"].ToString();
                            string userId = reader["userId"].ToString();
                            Dashboard dashboard = new Dashboard(userName, userEmail, userPassword, userId);
                            dashboard.Show();
                            MessageBox.Show("Login Succesful"); return;
                            
                        }
                    }
                }
                catch (Exception ex) 
                {
                    if (MessageBox.Show(ex.Message, "Database connection errro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { Environment.Exit(0); }
                }
            }
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
                DBConnection DB = new DBConnection();
                SqlConnection conn = DB.openConnection();

                try
                {
                    string query = "INSERT INTO [User] (userId,name,email,password) VALUES (@userId,@name,@email,@password)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    int row = cmd.ExecuteNonQuery();

                    if (row > 0) {

                        MessageBox.Show("Registerd succesfully");
                        LoginPanel.Visible = true;
                        RegisterPanel.Visible = false;

                    }
                    
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show(ex.Message, "Database connection errro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { Environment.Exit(0); }
                }
            }
        }
    }
}
