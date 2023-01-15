using ExpenseTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Factory.BudgetFactory
{
    public class ExpenseBudgetCreator : BudgetTypeCreator
    {
        public ExpenseBudgetCreator(  string name, DateTime startDate, DateTime endDate,User user) : base(  name, startDate, endDate,user)
        {
        }

        public override void CreateBudgetItem(string note, double value, Category category, DateTime td)
        {
            BudgetItems.Add(new IncomeBudget(category, td, note, value));

        }
    }
}
