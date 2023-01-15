using ExpenseTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Factory.BudgetFactory
{
    public class IncomeBudget : Budget
    {
        public IncomeBudget(Category c, DateTime dt, string note, double amt) { Category = c; Note = note; ID = Guid.NewGuid().ToString(); Amount = amt; }

    }
}
