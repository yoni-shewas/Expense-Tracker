using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Expense_Tracker
{
    internal class DBConnection
    {
        private SqlConnection conn;

        public DBConnection()
        {
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\yonat\\source\\repos\\Expense Tracker\\ExpenseDB.mdf\";Integrated Security=True;Connect Timeout=30");
        }
    }
}
