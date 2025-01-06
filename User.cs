using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracker
{
    internal class User
    {
        private string email;
        private string password;
        private string name; 

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
        //public void log_expense()
        //{

        //}
        //public bool set_budget()
        //{

        //}
        //public string view_expense()
        //{

        //}
        //public string view_budget()
        //{

        //}
        //public void generate_reports()
        //{

        //}
    }
}
