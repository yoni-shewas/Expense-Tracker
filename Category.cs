using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace Expense_Tracker
{
    internal class Category
    {
        private string name;
        private string description;

        public Category(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public Category()
        {
            
        }

        public void addCategory()
        {

            Guid categoryId = Guid.NewGuid();

            DBConnection DB = new DBConnection();
            SqlConnection conn = DB.openConnection();

            try
            {
                string query = @"
                INSERT INTO Category (categoryId, name, description)
                VALUES
                (@categoryId, @name, @description);";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@categoryId", Guid.NewGuid());
                cmd.Parameters.AddWithValue("@name", "Food");
                cmd.Parameters.AddWithValue("@description", "Expenses for food and dining");

        

       
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Categories added successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
           
                conn.Close();
            }





        }
        public void deleteCategory()
        {
            // Delete category from database
        }
    }
}
