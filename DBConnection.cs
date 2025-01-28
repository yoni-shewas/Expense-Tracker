using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Expense_Tracker
{
    internal class DBConnection
    {
        private SqlConnection conn;


        public SqlConnection openConnection()
        {
            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\paulo\\Videos\\rad final asg\\Expense-Tracker\\ExpenseDB.mdf\";Integrated Security=True;Connect Timeout=30";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Database connection errro", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { Environment.Exit(0); }
            }
            return null;

        }
        public void closeConnection()
        {
            if (conn != null)
            {
                conn.Close();
                conn = null;
            }
        }
    }
}
