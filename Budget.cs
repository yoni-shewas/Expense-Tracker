using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace Expense_Tracker
{
    internal class Budget
    {
        public int BudgetId { get; set; }
        public int UserId { get; set; }
        public double BudgetAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public double GetRemainingBudgetFromExpenses(string userId)
        {
            DBConnection DB = new DBConnection();
            SqlConnection conn = DB.openConnection();
            double remainingBudget = 0;

            try
            {
                string budgetQuery = @"
                SELECT TOP 1 budgetAmount 
                FROM Budget
                WHERE userId = @userId
                ORDER BY startDate DESC";

                SqlCommand budgetCmd = new SqlCommand(budgetQuery, conn);
                budgetCmd.Parameters.AddWithValue("@userId", userId);

                object budgetResult = budgetCmd.ExecuteScalar();

                if (budgetResult != null)
                {
                    double totalBudget = Convert.ToDouble(budgetResult);

              
                    string expenseQuery = @"
                    SELECT ISNULL(SUM(amount), 0) AS totalExpenses 
                    FROM Expense
                    WHERE userId = @userId";

                    SqlCommand expenseCmd = new SqlCommand(expenseQuery, conn);
                    expenseCmd.Parameters.AddWithValue("@userId", userId);

                    object expenseResult = expenseCmd.ExecuteScalar();
                    double totalExpenses = Convert.ToDouble(expenseResult);


                    remainingBudget = totalBudget - totalExpenses;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return remainingBudget;
        }


        public string GetMostRecentBudget(string userId)
        {
            DBConnection DB = new DBConnection();
            SqlConnection conn = DB.openConnection();
            string recentBudget = null;

            try
            {
                string query = @"
                SELECT TOP 1 budgetAmount
                FROM Budget
                WHERE userId = @userId
                ORDER BY startDate DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    recentBudget = reader["budgetAmount"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return recentBudget;
        }


        public bool AddBudget(string userId, string budgetAmount)
        {
            DBConnection DB = new DBConnection();
            SqlConnection conn = DB.openConnection();
            DateTime startDate = DateTime.Now;
            try
            {
                string query = "INSERT INTO Budget (budgetId,userId, budgetAmount, startDate, endDate) VALUES (@budgetId, @userId, @budgetAmount, @startDate, @endDate)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@budgetId", Guid.NewGuid());
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@budgetAmount", budgetAmount);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", startDate.AddDays(30));

                int rows = cmd.ExecuteNonQuery();

                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


        public bool EditBudget(string userId, string newAmount)
        {
            DBConnection DB = new DBConnection();
            SqlConnection conn = DB.openConnection();

            try
            {
                string query = @"
                                UPDATE Budget 
                                SET budgetAmount = @budgetAmount 
                                WHERE budgetId = (
                                    SELECT TOP 1 budgetId 
                                    FROM Budget 
                                    WHERE userId = @userId 
                                    ORDER BY startDate DESC
                                )";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@budgetAmount", newAmount);
                cmd.Parameters.AddWithValue("@userId", userId);

                int rows = cmd.ExecuteNonQuery();

                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }



        public bool DeleteBudget(string userId)
        {
            DBConnection DB = new DBConnection();
            SqlConnection conn = DB.openConnection();

            try
            {
                string query = @"
                        DELETE FROM Budget
                        WHERE budgetId = (
                            SELECT TOP 1 budgetId
                            FROM Budget
                            WHERE userId = @userId
                            ORDER BY startDate DESC
                        )";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId); 

                int rows = cmd.ExecuteNonQuery();

                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }




    }

}
