using ExpenseTrackingApp.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackingApp.Reports
{
    internal class BudgetReport : ReportStrategy
    {
        public override void Print()
        {
            foreach (var  incomeTransaction in incomeItems)
            {
                var cat = incomeTransaction.Category.Name;
                bool found = false;
                double value = 0;
                foreach (var item in budgetIncomeItems) { 
                    if(cat == item.Category.Name)
                    {
                        value = item.Amount;
                        found = true; break;
                    
                    }
                }

                if (!found) { Console.WriteLine("No budget found for: " + cat + " - actual income in this categroy is Rs:" + incomeTransaction.Amount); }
                else
                {
                    Console.WriteLine(  cat + " budgeted value Rs: "+ value +"- actual income in this categroy is Rs:" + incomeTransaction.Amount);
                }

            }

            foreach (var expenseTransaction in expensetems)
            {
                var cat = expenseTransaction.Category.Name;
                bool found = false;
                double value = 0;
                foreach (var item in budgetIncomeItems)
                {
                    if (cat == item.Category.Name)
                    {
                        value = item.Amount;
                        found = true; break;

                    }
                }

                if (!found) { Console.WriteLine("No budget found for: " + cat + " - actual income in this categroy is Rs:" + expenseTransaction.Amount); }
                else
                {
                    Console.WriteLine(cat + " budgeted value Rs: " + value + "- actual income in this categroy is Rs:" + expenseTransaction.Amount);
                }

            }
        }
    }
}
