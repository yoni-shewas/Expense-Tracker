using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Tracker
{
    internal class Expense 
    {
        private float amount;
        private string category;
        DateTime date;

        

        public void add_expense(string id, string expense, string category)
        {

            string query = @"Insert into [Expense] (expenseId, userId,amount,categoryId, date) values (
                            @expenseId,
                            @userId,
                            @amount,
                            @categoryId,
                            @date
                )";

            SqlConnection DB = new DBConnection().openConnection();

            try
            {
                SqlCommand command = new SqlCommand(query, DB);
                command.Parameters.AddWithValue("@expenseId", Guid.NewGuid());
                command.Parameters.AddWithValue("@userId", id);
                command.Parameters.AddWithValue("@categoryId", category);
                command.Parameters.AddWithValue("@amount", expense);
                command.Parameters.AddWithValue("@date", DateTime.Now);


                int row = command.ExecuteNonQuery();

                if (row > 0)
                {
                    MessageBox.Show($" Expense added!");
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
        public void update_expense() 
        {
        }

        internal void ExpenseTable(DataGridView dataGridView2, string selectedCategory)
        {
            throw new NotImplementedException();
        }

        public DataTable GetExpenseData(
        string id,
        string categoryFilter = null,
        DateTime? startDateFilter = null,
        DateTime? endDateFilter = null,
        decimal? minAmountFilter = null,
        decimal? maxAmountFilter = null)
        {
      
                string query = @"
            SELECT
                u.name AS userName,
                c.name AS categoryName,
                e.amount AS Amount,
                e.date AS Date
            FROM 
                dbo.Expense e
            JOIN 
                dbo.[User] u ON e.userId = u.userId
            JOIN 
                dbo.Category c ON e.categoryId = c.categoryId
            WHERE 
                e.userId = @userId";

      
            if (!string.IsNullOrEmpty(categoryFilter))
            {
                query += " AND c.name = @categoryFilter";
            }

            if (startDateFilter.HasValue && endDateFilter.HasValue)
            {
                query += " AND e.date BETWEEN @startDateFilter AND @endDateFilter";
            }
            else if (startDateFilter.HasValue)
            {
                query += " AND e.date >= @startDateFilter";
            }
            else if (endDateFilter.HasValue)
            {
                query += " AND e.date <= @endDateFilter";
            }

            if (minAmountFilter.HasValue && maxAmountFilter.HasValue)
            {
                query += " AND e.amount BETWEEN @minAmountFilter AND @maxAmountFilter";
            }
            else if (minAmountFilter.HasValue)
            {
                query += " AND e.amount >= @minAmountFilter";
            }
            else if (maxAmountFilter.HasValue)
            {
                query += " AND e.amount <= @maxAmountFilter";
            }

            query += " ORDER BY e.date DESC;";

   
            SqlConnection DB = null;
            SqlCommand command = null;

            try
            {
                DB = new DBConnection().openConnection();
                command = new SqlCommand(query, DB);


                Guid userId = Guid.Parse(id);
                command.Parameters.Add("@userId", SqlDbType.UniqueIdentifier).Value = userId;

               
                if (!string.IsNullOrEmpty(categoryFilter))
                {
                    command.Parameters.AddWithValue("@categoryFilter", categoryFilter);
                }

                if (startDateFilter.HasValue)
                {
                    command.Parameters.AddWithValue("@startDateFilter", startDateFilter.Value);
                }

                if (endDateFilter.HasValue)
                {
                    command.Parameters.AddWithValue("@endDateFilter", endDateFilter.Value);
                }

                if (minAmountFilter.HasValue)
                {
                    command.Parameters.AddWithValue("@minAmountFilter", minAmountFilter.Value);
                }

                if (maxAmountFilter.HasValue)
                {
                    command.Parameters.AddWithValue("@maxAmountFilter", maxAmountFilter.Value);
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                int rowsAffected = dataAdapter.Fill(dataTable);

                MessageBox.Show($"Rows returned: {rowsAffected}");
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
     
                if (DB != null && DB.State == ConnectionState.Open)
                {
                    DB.Close();
                }
                if (command != null)
                {
                    command.Dispose();
                }
            }

            return null;
        }


        public double GetTotalExpense(string id)
        {
            string query = @"
                            SELECT
                                SUM(amount) AS totalExpenses
                            FROM 
                                dbo.Expense
                            WHERE 
                                userId = @userId";
            SqlConnection DB = new DBConnection().openConnection();
            try
            {
                SqlCommand command = new SqlCommand(query, DB);
                command.Parameters.AddWithValue("@userId", id);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToDouble(result);
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
            return 0;
        }


    }


}
