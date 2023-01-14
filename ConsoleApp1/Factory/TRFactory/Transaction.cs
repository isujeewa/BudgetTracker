using ExpenseTrackingApp.Models;
using System.Xml.Linq;

namespace ConsoleApp1.Factory.TRFactory
{
    // abstract transaction 
    public abstract class Transaction
    {
        private string id;
        private ICategory category;
        private double amount;
        private DateTime date;
        private string note;

        public string ID
        {

            get { return id; }   // get method
            set { id = value; }  // set method
        }
        public ICategory Category
        {

            get { return category; }   // get method
            set { category = value; }  // set method
        }
        public string Note
        {

            get { return note; }   // get method
            set { note = value; }  // set method
        }

        public double Amount
        {

            get { return amount; }   // get method
            set { amount = value; }  // set method
        }

        public DateTime Date
        {

            get { return date; }   // get method
            set { date = value; }  // set method
        }
    }
}
