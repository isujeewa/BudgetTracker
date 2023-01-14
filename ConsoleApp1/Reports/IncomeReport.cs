using ConsoleApp1.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackingApp.Reports
{
    internal class IncomeReport : Report
    {
        public override void Print()
        {
         
           foreach (var item in incomeItems)
            {
               Console.WriteLine(item.Category.Name +"-"+ item.Amount);
            }
        }
    }
}
