using ExpenseTrackingApp.Factory.Concretes.IncomeCategories;
using ExpenseTrackingApp.Models;

namespace ConsoleApp1.Factory.TRFactory
{
    //concatre ceator
    public class IncomeCreator : TransactionTypeCreator
    {
        public override void CreateTransaction(string note, double value , Category category, DateTime td , User user , bool isRecurrent)
        {
            Transactions.Add(new Income(category, td, note, value, user,isRecurrent));
        }
    }
}
