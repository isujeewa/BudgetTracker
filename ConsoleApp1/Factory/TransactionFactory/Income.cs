using ExpenseTrackingApp.Factory.Concretes.IncomeCategories;
using ExpenseTrackingApp.Models;

namespace ConsoleApp1.Factory.TRFactory
{
    //concrete product
    public class Income : Transaction
    {
        public Income( Category c , DateTime dt , string note , double  amt, User user) { Category = c;  Date = dt; Note = note; ID = Guid.NewGuid().ToString(); Amount = amt; User = user;  }
    }
}
