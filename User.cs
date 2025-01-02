using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
