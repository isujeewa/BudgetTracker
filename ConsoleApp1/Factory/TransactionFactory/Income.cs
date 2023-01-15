using ExpenseTrackingApp.Factory.Concretes.IncomeCategories;
using ExpenseTrackingApp.Models;

namespace ConsoleApp1.Factory.TRFactory
{
    //concrete transaction 
    public class Income : Transaction
    {
        public Income( Category c , DateTime dt , string note , double  amt, User user, bool isRecurrent) 
        { Category = c;  Date = dt; Note = note; ID = Guid.NewGuid().ToString(); Amount = amt; User = user; IsRecurrent = isRecurrent; }
    }
}
