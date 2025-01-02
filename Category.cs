using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void addCategory()
        {
            // Add category to database
        }
        public void deleteCategory()
        {
            // Delete category from database
        }
    }
}
