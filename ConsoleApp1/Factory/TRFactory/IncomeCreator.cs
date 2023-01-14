using ExpenseTrackingApp.Factory.Concretes.IncomeCategories;
using ExpenseTrackingApp.Models;

namespace ConsoleApp1.Factory.TRFactory
{
    //concatre ceator
    public class IncomeCreator : TransactionTypeCreator
    {
        public override void CreateTransaction(string note, double value , ICategory category, DateTime td   )
        {
            Transactions.Add(new Income(category, td, note, value));
        }
    }
}
