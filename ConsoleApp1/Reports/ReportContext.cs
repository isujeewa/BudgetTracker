using ExpenseTrackingApp.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackingApp.Reports
{
    public class ReportContext
    {
        public ReportStrategy reportStrategy;
        public List<Item> incomeItems { get; set; }
        public List<Item> expensetems { get; set; }
        public List<Item> budgetIncomeItems { get; set; }
        public List<Item> budgetExpensetems { get; set; }

        public ReportContext(ReportStrategy reportStrategy , List<Item> incomeItems , List<Item> expensetems ,
            List<Item> budgetIncomeItems, List<Item> budgetExpensetems)
        {
            this.reportStrategy = reportStrategy;
            this.reportStrategy.incomeItems = incomeItems;
            this.reportStrategy.expensetems = expensetems;
            this.reportStrategy.budgetIncomeItems = budgetIncomeItems;
            this.reportStrategy.budgetExpensetems = budgetExpensetems;
        }
       
            public void Print()
        {
            reportStrategy.Print();
        }
    }
}
