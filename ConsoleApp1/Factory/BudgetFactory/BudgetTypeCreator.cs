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


        public BudgetTypeCreator(  string name, DateTime startDate, DateTime endDate)
        {
            ID = Guid.NewGuid().ToString();
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
        }

        public List<Budget> BudgetItems { get { return budgetItems; } }

        public abstract void CreateBudgetItem(string note, double value, ICategory category, DateTime td);
    }
}
