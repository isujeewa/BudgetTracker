using ExpenseTrackingApp.Models;

namespace ConsoleApp1.Factory.BudgetFactory
{
    public abstract class Budget
    {
        public string ID { get; set; }
        public ICategory Category { get; set; }

        public double Amount { get; set; }

        public string Note { get; set; }



    }
}
