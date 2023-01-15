using ExpenseTrackingApp.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackingApp.Reports
{
    //abstract stratergy 
    public abstract class ReportStrategy
    {
        public List<Item> incomeItems { get; set; }
        public List<Item> expensetems { get; set; }
        public List<Item> budgetIncomeItems { get; set; }
        public List<Item> budgetExpensetems { get; set; }
        public abstract void Print();
    }
}
