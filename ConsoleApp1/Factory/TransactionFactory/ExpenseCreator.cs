using ExpenseTrackingApp.Models;

namespace ConsoleApp1.Factory.TRFactory
{
    //Concreate ceator
    public class ExpenseCreator : TransactionTypeCreator
    {


        public override void CreateTransaction(string note, double value, Category category, DateTime td ,User user )
        {
            Transactions.Add(new Expense(category,td, note,value,user));
        }
    }
}
