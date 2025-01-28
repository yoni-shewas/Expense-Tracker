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
        private Dictionary<string, string> categoryId;

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
            (string budget, string income) = new Budget().GetMostRecentBudget(id);
            reaminingBudget.Text = new Budget().GetRemainingBudgetFromExpenses(id).ToString() + " / " + budget ;
            IncomeTextBox.Text = income ;
            TotalIncome.Text = income ;
            if (income != null) {
                deleteIncomeBtn.Visible = true;
                editIncomeBtn.Visible = true ;
            }
            TotalExpense.Text = new Expense().GetTotalExpense(id).ToString();
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

            (categories, categoryId) = LoadCategoryFilter();

            DeleteCategory.Items.Clear();
            DeleteCategory.Items.AddRange(categories);

            ExpenseNav.BackColor = SystemColors.GradientInactiveCaption;
    
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


            Expense expense = new Expense();

            Expense exp = new Expense();

            DataTable expenseData = exp.GetExpenseData(id);

       
            dataGridView2.DataSource = expenseData;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.DefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }

            (categories, categoryId) = LoadCategoryFilter();

            filterCategoryComboBox.Items.Clear();
            filterCategoryComboBox.Items.AddRange(categories);

            categoryComboBox.Items.Clear();
            categoryComboBox.Items.AddRange(categories);

            filterStartDatePicker.ShowCheckBox = true;
            filterEndDatePicker.ShowCheckBox = true;

             (string budget, string income) = new Budget().GetMostRecentBudget(id);

            if (budget != null) { 
                BudgetBox.Text = budget;
                EditBudget.Visible = true;
               ;
            }

        }




        private void filterButton_Click(object sender, EventArgs e)

        {
            
            (categories, categoryId) = LoadCategoryFilter();

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

        private (string[], Dictionary<string, string>) LoadCategoryFilter()
        {
            List<string> categoryList = new List<string>();
            Dictionary<string, string> categoryDict = new Dictionary<string, string>();

            string categoryQuery = "SELECT categoryId, name FROM dbo.Category";
            SqlConnection DB = new DBConnection().openConnection();

            try
            {
                SqlCommand command = new SqlCommand(categoryQuery, DB);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    categoryList.Add(name);
                    categoryDict[name] = reader["categoryId"].ToString();
                }

                return (categoryList.ToArray(), categoryDict);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return (new string[0], new Dictionary<string, string>());
            }
            finally
            {
                if (DB.State == ConnectionState.Open)
                    DB.Close();
            }
        }


        private void AddExpenseBtn_Click(object sender, EventArgs e)
        {
            string expense = expenseAmountBox.Text;
            string category = categoryComboBox.Text;
            string categoryID = categoryId[category];

            if (string.IsNullOrEmpty(expense) || string.IsNullOrEmpty(category)) 
            {
                MessageBox.Show("Input in all the feilds");
                return;
            }
            else
            {
                Expense addExpense = new Expense();
                addExpense.add_expense(id,expense, categoryID);
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_budget_click(object sender, EventArgs e)
        {
            string BudgetAmount = BudgetBox.Text;
            bool isAdded = new Budget().AddBudget(id, BudgetAmount);

            if(isAdded)
            {
                reaminingBudget.Text = new Budget().GetRemainingBudgetFromExpenses(id).ToString() + " / " + BudgetAmount;
                BudgetBox.Text = BudgetAmount;
                MessageBox.Show("Budget added successfully");
            }
        }

        private void EditBudget_Click(object sender, EventArgs e)
        {
            string BudgetAmount = BudgetBox.Text;
            bool isAdded = new Budget().EditBudget(id, BudgetAmount);

            if (isAdded)
            {
                reaminingBudget.Text = new Budget().GetRemainingBudgetFromExpenses(id).ToString() + " / " + BudgetAmount;
                BudgetBox.Text = BudgetAmount;
                MessageBox.Show("Budget edited successfully");
            }
        }


        private void updateProfileBtn_Click(object sender, EventArgs e)
        {

            string newName = UpadteNameBox.Text;
            string newEmail = UpdateEmailBox.Text;

            if (!string.IsNullOrEmpty(newName) && !string.IsNullOrEmpty(newEmail))
            {
                bool isUpdated = new User(email, password).UpdateProfile(newName,newEmail,null);
                if (isUpdated)
                {
                    UserNameLabel.Text = newName;
                    MessageBox.Show("Profile updated successfully");
                }
            }
            else if (!string.IsNullOrEmpty(newName))
            {
                bool isUpdated = new User(email, password).UpdateProfile(newName, null, null);
                if (isUpdated)
                {
                    UserNameLabel.Text = newName;
                    MessageBox.Show("Profile updated successfully");
                }
            }
            else if (!string.IsNullOrEmpty(newName))
            {
                bool isUpdated = new User(email,password).UpdateProfile(null, newEmail, null);
                if (isUpdated)
                {
                    MessageBox.Show("Profile updated successfully");
                }
            }
            else
            {
                MessageBox.Show("Please input in the fields");
            }
           

        }

        private void UpdatePasswordBtn_Click(object sender, EventArgs e)
        {
            string newPassword = UpdatePasswordBox.Text;
            string ConfirmPassword = UpdatePasswordConfirmBox.Text;

            if (!string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(ConfirmPassword))
            {
                if (newPassword != ConfirmPassword)
                {
                    MessageBox.Show("Passwords do not match");
                }
                else
                {
                    bool isUpdated = new User(email, password).UpdateProfile(null,null, newPassword);
                    if (isUpdated)
                    {
                        MessageBox.Show("Password Changed successfully");
                    }
                    else
                    {
                        MessageBox.Show("Password Not changed");
                    }
                }
            }
            else
            {
                MessageBox.Show("Input Both Feilds");
            }

        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            string newCategory = addCategoryBox.Text;
            string newDescription = descriptionBox.Text;

            if (!string.IsNullOrEmpty(newCategory) && !string.IsNullOrEmpty(newCategory))
            {
                SqlConnection conn = new DBConnection().openConnection();
                Guid catID = new Guid();

                try
                {
                    string query = "INSERT INTO [Category] (categoryId,name,description ) VALUES (@categoryId,@name,@description)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@categoryId", catID);
                    cmd.Parameters.AddWithValue("@name", newCategory);
                    cmd.Parameters.AddWithValue("@description", newDescription);
                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                    {
                        (categories, categoryId) = LoadCategoryFilter();

                        DeleteCategory.Items.Clear();
                        DeleteCategory.Items.AddRange(categories);
                        MessageBox.Show("Categories added");
                    }

                }
                catch (Exception ex)
                {
                    if (MessageBox.Show(ex.Message, "Database connection errro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { Environment.Exit(0); }
                }
                finally { conn.Close(); }


            }
            else
            {
                MessageBox.Show("Input In the Feilds");

            }
        }

        private void DeleteCategoryBtn_Click(object sender, EventArgs e)
        {

            string category = DeleteCategory.Text;
            string categoryID = categoryId[category];

            if (!string.IsNullOrEmpty(categoryID))
            {
                SqlConnection conn = new DBConnection().openConnection();

                try
                {
                    string query = @"
                        DELETE FROM Category
                        WHERE categoryId = @categoryId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@categoryId", categoryID);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        (categories, categoryId) = LoadCategoryFilter();

                        DeleteCategory.Items.Clear();
                        DeleteCategory.Items.AddRange(categories);
                        MessageBox.Show("Category Deleted");
                    }

                }
                catch (Exception ex)
                {
                    if (MessageBox.Show(ex.Message, "Database connection errro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { Environment.Exit(0); }
                }
                finally { conn.Close(); }


            }
            else
            {
                MessageBox.Show("Invalid Category");

            }


        }

        private void addIncomeBtn_Click(object sender, EventArgs e)
        {
            string Income = IncomeTextBox.Text;

            if (!string.IsNullOrEmpty(Income))
            {
                bool isAdded = new Budget().AddIncome(id, Income);
                if (isAdded)
                {
                    IncomeTextBox.Text = Income;
                    TotalIncome.Text = Income;
                    MessageBox.Show("Income added successfully");
                }
            }
            else
            {
                MessageBox.Show("Input in the field");
            }
        }

        private void editIncomeBtn_Click(object sender, EventArgs e)
        {
            string Income = IncomeTextBox.Text;
            if (!string.IsNullOrEmpty(Income))
            {
                bool isAdded = new Budget().AddIncome(id, Income);
                if (isAdded)
                {
                    IncomeTextBox.Text = Income;
                    TotalIncome.Text = Income;
                    MessageBox.Show("Income edited successfully");
                }
            }
            else
            {
                MessageBox.Show("Input in the field");
            }

        }
    }
    }
    

