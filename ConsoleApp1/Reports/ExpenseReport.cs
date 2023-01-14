﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackingApp.Reports
{
    internal class ExpenseReport : Report
    {
        public override void Print()
        {
            foreach (var item in expensetems)
            {
                Console.WriteLine(item.Category.Name + "-" + item.Amount);
            }
        }
    }
}