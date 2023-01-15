using ExpenseTrackingApp.Factory;
using ExpenseTrackingApp.Models;
using System.Xml.Linq;

namespace ConsoleApp1.Factory.TRFactory
{
    // abstract transaction 
    public abstract class Transaction : Item
    {
        private DateTime date;
        private bool isRecurrent;

        public DateTime Date
        {
            get { return date; }   // get method
            set { date = value; }  // set method
        }

        public bool IsRecurrent
        {
            get { return isRecurrent; }   // get method
            set { isRecurrent = value; }  // set method
        }
    }
}
