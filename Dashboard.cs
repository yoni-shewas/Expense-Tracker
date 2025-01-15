using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Expense_Tracker
{
    public partial class Dashboard : Form
    {
        private string email;
        private string password;
        private string name;
        private string id;
        private string[] categories;

        public Dashboard(string userName, string userEmail, string userPassword, string userId)
        {
            InitializeComponent();
            email = userEmail;
            password = userPassword;
            name = userName;
            id = userId;

            UserNameLabel.Text = userName;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.TableLoad();
            this.LoadPieChart();
        }

        private void TableLoad()
        {
            string query = @"
                    SELECT TOP 10
                        u.name AS userName,
                        c.name AS categoryName,
                        e.amount AS Amount,
                        e.date AS Date
                    FROM 
                        dbo.Expense e
                    JOIN 
                        dbo.[User] u ON e.userId = @userId
                    JOIN 
                        dbo.Category c ON e.categoryId = c.categoryId
                    WHERE 
                        e.userId = @userId
                        AND u.userId IS NOT NULL 
                        AND c.categoryId IS NOT NULL
                    ORDER BY 
                        e.date DESC;";

            SqlConnection DB = new DBConnection().openConnection();

            try
            {
                SqlCommand command = new SqlCommand(query, DB);
                command.Parameters.AddWithValue("@userId", id);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.DefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;  
                    row.DefaultCellStyle.ForeColor = Color.Black;  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (DB.State == ConnectionState.Open)
                    DB.Close();
            }
        }


        private void LoadPieChart()
        {
            string query = @"
                        SELECT 
                            c.name AS CategoryName,
                            SUM(e.amount) AS TotalAmount
                        FROM 
                            dbo.Expense e
                        JOIN 
                            dbo.Category c ON e.categoryId = c.categoryId
                        WHERE 
                            e.userId = @userId
                        GROUP BY 
                            c.name;";

            try
            {
                SqlConnection DB = new DBConnection().openConnection();

                SqlCommand command = new SqlCommand(query, DB);
                command.Parameters.AddWithValue("@userId", id);

                SqlDataReader reader = command.ExecuteReader();

                summaryPie.Series.Clear();
                summaryPie.Legends.Clear();

                Legend legend = new Legend("Legend1")
                {
                    Docking = Docking.Bottom,
                    Alignment = StringAlignment.Center
                };
                summaryPie.Legends.Add(legend);

                Series series = new Series
                {
                    Name = "Expenses",
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true,
                };
                summaryPie.Series.Add(series);

                while (reader.Read())
                {
                    string categoryName = reader["CategoryName"].ToString();
                    decimal totalAmount = Convert.ToDecimal(reader["TotalAmount"]);

                    series.Points.AddXY(categoryName, totalAmount);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading chart: {ex.Message}");
            }
        }

        private void HomeNav_Click(object sender, EventArgs e)
        {

            ProfilePanel.Hide();
            HomePanel.Show();
            BudgetPanel.Hide();
            ExpensePanel.Hide();

            HomeNav.BackColor = SystemColors.MenuHighlight;
            //HomeNav.ForeColor = Color.Gray;
            ProfileNav.BackColor = SystemColors.GradientInactiveCaption;
            BudgetNav.BackColor = SystemColors.GradientInactiveCaption;
            ExpenseNav.BackColor = SystemColors.GradientInactiveCaption;
           
        }

        private void ProfileNav_Click(object sender, EventArgs e)
        {
            ProfilePanel.Show();
            HomePanel.Hide();
            BudgetPanel.Hide();
            ExpensePanel.Hide();

            HomeNav.BackColor = SystemColors.GradientInactiveCaption;

            ProfileNav.BackColor = SystemColors.MenuHighlight;
            //ProfileNav.ForeColor = Color.Gray;
            
            ExpenseNav.BackColor = SystemColors.GradientInactiveCaption;
            BudgetNav.BackColor = SystemColors.GradientInactiveCaption;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BudgetNav_Click(object sender, EventArgs e)
        {
            ProfilePanel.Hide();
            HomePanel.Hide();
            BudgetPanel.Show();
            ExpensePanel.Hide();

            BudgetNav.BackColor =  SystemColors.MenuHighlight;
          
            ProfileNav.BackColor = SystemColors.GradientInactiveCaption;
          
            ExpenseNav.BackColor = SystemColors.GradientInactiveCaption;
            HomeNav.BackColor = SystemColors.GradientInactiveCaption;

        }

        private void ExpenseNav_Click(object sender, EventArgs e)
        {
            ProfilePanel.Hide();
            HomePanel.Hide();
            BudgetPanel.Hide();
            ExpensePanel.Show();

            ExpenseNav.BackColor = SystemColors.MenuHighlight;
            //ExpenseNav.ForeColor = Color.Gray;
            ProfileNav.BackColor = SystemColors.GradientInactiveCaption;
     
            HomeNav.BackColor = SystemColors.GradientInactiveCaption;
            BudgetNav.BackColor = SystemColors.GradientInactiveCaption;

            Expense expense = new Expense();

            Expense exp = new Expense();

            DataTable expenseData = exp.GetExpenseData(id);

       
            dataGridView2.DataSource = expenseData;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.DefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }


            filterCategoryComboBox.Items.Clear();
            categories = LoadCategoryFilter();
            filterCategoryComboBox.Items.AddRange(categories);
            
            filterStartDatePicker.ShowCheckBox = true;
            filterEndDatePicker.ShowCheckBox = true;
  


        }




        private void filterButton_Click(object sender, EventArgs e)
        {
            categories = LoadCategoryFilter();

            string selectedCategory = filterCategoryComboBox.SelectedItem?.ToString();
            DateTime? selectedStartDate = (filterStartDatePicker.Value.Date == DateTime.Now.Date)
                    ? null
                    : (DateTime?)filterStartDatePicker.Value;

            DateTime? selectedEndDate = (filterEndDatePicker.Value.Date == DateTime.Now.Date)
                ? null
                : (DateTime?)filterEndDatePicker.Value;

            decimal? selectedMinAmount = filterMinAmountNumericUpDown.Value > 0 ? (decimal?)filterMinAmountNumericUpDown.Value : null;
            decimal? selectedMaxAmount = filterMaxAmountNumericUpDown.Value > 0 ? (decimal?)filterMaxAmountNumericUpDown.Value : null;


          

            Expense exp = new Expense();

            DataTable expenseData = exp.GetExpenseData(id, selectedCategory, selectedStartDate, selectedEndDate, selectedMinAmount, selectedMaxAmount);


        
            dataGridView2.DataSource = expenseData;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.DefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private string[] LoadCategoryFilter()
        {

            List<string> categoryList = new List<string>();

           
            string categoryQuery = "SELECT name FROM dbo.Category";
            SqlConnection DB = new DBConnection().openConnection();

            try
            {
                SqlCommand command = new SqlCommand(categoryQuery, DB);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    categoryList.Add(reader["name"].ToString());
                }

                return categoryList.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return new string[0]; 
            }
            finally
            {
                if (DB.State == ConnectionState.Open)
                    DB.Close();
            }
        }
    }
    }
    

