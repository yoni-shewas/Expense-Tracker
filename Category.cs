using System; // Importing the System namespace for basic functionality like data types and collections.
using System.Collections.Generic; // Importing the namespace for working with generic collections (not used here directly, but could be useful).
using System.Data.SqlClient; // Importing the SQL Client namespace to interact with the database using SQL Server.
using System.Linq; // Importing the namespace for LINQ functionality (not directly used here).
using System.Text; // Importing the namespace for working with text and strings (not used here).
using System.Threading.Tasks; // Importing the namespace for async tasks (not used here).
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView; // Importing specific UI elements from Windows Forms (not directly used here).
using System.Windows.Forms; // Importing Windows Forms for UI elements like MessageBox.

namespace Expense_Tracker // Defining the namespace for this project, which helps in organizing related classes.
{
    internal class Category // Defining the Category class which will handle category-related operations like adding and deleting categories.
    {
        private string name; // Private field to store the category's name.
        private string description; // Private field to store the category's description.

        // Constructor to initialize the category with a name and description.
        public Category(string name, string description)
        {
            this.name = name; // Initializing the name field with the passed argument.
            this.description = description; // Initializing the description field with the passed argument.
        }

        // Default constructor without parameters (empty, to allow object creation without immediately setting fields).
        public Category()
        {

        }

        // Method to add a new category to the database.
        public void addCategory()
        {
            Guid categoryId = Guid.NewGuid(); // Generate a new unique identifier for the category.

            DBConnection DB = new DBConnection(); // Creating a new DBConnection object to handle the database connection.
            SqlConnection conn = DB.openConnection(); // Opening a new connection to the database.

            try
            {
                // SQL query to insert a new category into the Category table in the database.
                string query = @"
                INSERT INTO Category (categoryId, name, description)
                VALUES
                (@categoryId, @name, @description);";

                SqlCommand cmd = new SqlCommand(query, conn); // Creating a SQL command to execute the query.

                // Adding parameters to the SQL command to prevent SQL injection attacks.
                cmd.Parameters.AddWithValue("@categoryId", Guid.NewGuid()); // Adding the categoryId as a parameter.
                cmd.Parameters.AddWithValue("@name", "Food"); // Hardcoded name value for the category.
                cmd.Parameters.AddWithValue("@description", "Expenses for food and dining"); // Hardcoded description value.

                int rowsAffected = cmd.ExecuteNonQuery(); // Executing the query and getting the number of rows affected.

                // If rows were affected (i.e., the category was added successfully), show a success message.
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Categories added successfully"); // Display a success message box.
                }
            }
            catch (Exception ex) // Catch any exceptions that occur during the database operation.
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display an error message box.
            }
            finally
            {
                conn.Close(); // Ensure that the database connection is closed, even if an error occurred.
            }
        }

        // Method to delete a category from the database (currently empty, to be implemented).
        public void deleteCategory()
        {
            // Delete category from the database (functionality not implemented here).
        }
    }
}
