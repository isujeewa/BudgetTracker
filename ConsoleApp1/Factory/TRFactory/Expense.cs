using ExpenseTrackingApp.Factory.Concretes.IncomeCategories;
using ExpenseTrackingApp.Models;

namespace ConsoleApp1.Factory.TRFactory
{
    //contreate product
    public class Expense : Transaction
    {
        public Expense(ICategory c, DateTime dt, string note ,double amt) { Category = c; Date = dt; Note = note; ID = Guid.NewGuid().ToString(); Amount = amt; }
    }
}
