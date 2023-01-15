using ExpenseTrackingApp.Factory;
using ExpenseTrackingApp.Models;
using System.Xml.Linq;

namespace ConsoleApp1.Factory.TRFactory
{
    // abstract transaction 
    public abstract class Transaction : Item
    {
        private DateTime date;
    




        public DateTime Date
        {

            get { return date; }   // get method
            set { date = value; }  // set method
        }

        public User User
        {

            get { return user; }   // get method
            set { user = value; }  // set method
        }
    }
}
