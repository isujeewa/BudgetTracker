using ExpenseTrackingApp.Factory.Concretes.IncomeCategories;
using ExpenseTrackingApp.Models;
using System.Transactions;

namespace ConsoleApp1.Factory.TRFactory
{
    //abstract creator
    public abstract class TransactionTypeCreator
    {
        private List<Transaction> transactions = new List<Transaction>();

        public TransactionTypeCreator()
        {

        }

        public List<Transaction> Transactions { get { return transactions; } }

        public abstract void CreateTransaction(string note, double value , ICategory category, DateTime td );
    }
}
