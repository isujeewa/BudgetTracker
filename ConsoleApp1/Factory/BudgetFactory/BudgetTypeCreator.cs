using ExpenseTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Factory.BudgetFactory
{
    public abstract class BudgetTypeCreator
    {
        private List<Budget> budgetItems = new List<Budget>();
        public string ID { get; set; }

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public User User { get; set; }


        public BudgetTypeCreator(  string name, DateTime startDate, DateTime endDate, User user)
        {
            ID = Guid.NewGuid().ToString();
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            User = user;
        }

        public List<Budget> BudgetItems { get { return budgetItems; } }

        public abstract void CreateBudgetItem(string note, double value, Category category, DateTime td);
    }
}
