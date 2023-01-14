using ExpenseTrackingApp.Models;

namespace ConsoleApp1.Factory.TRFactory
{
    //Concreate ceator
    public class ExpenseCreator : TransactionTypeCreator
    {


        public override void CreateTransaction(string note, double value, ICategory category, DateTime td  )
        {
            Transactions.Add(new Expense(category,td, note,value));
        }
    }
}
