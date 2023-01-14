using ExpenseTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Factory.BudgetFactory
{
    public class ExpenseBudget : Budget
    {
        public ExpenseBudget(ICategory c, DateTime dt, string note, double amt) { Category = c;   Note = note; ID = Guid.NewGuid().ToString(); Amount = amt; }
    }
}
