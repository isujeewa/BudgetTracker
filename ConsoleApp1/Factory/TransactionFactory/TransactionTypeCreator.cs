using ExpenseTrackingApp.Factory.Concretes.IncomeCategories;
using ExpenseTrackingApp.Models;
using System.Transactions;

namespace ConsoleApp1.Factory.TRFactory
{
    //abstract creator class
    public abstract class TransactionTypeCreator
    {
        private List<Transaction> transactions = new List<Transaction>();

        public TransactionTypeCreator()
        {
        }

        public List<Transaction> Transactions { get { return transactions; } }

        public abstract void CreateTransaction(string note, double value , Category category, DateTime td  , User user , bool isRecurrent);
    }
}
