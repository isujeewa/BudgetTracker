using ExpenseTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackingApp.Factory
{
    public abstract class Item
    {
        public string ID { get; set; }
        public ICategory Category { get; set; }

        public double Amount { get; set; }

        public string Note { get; set; }
    }
}
