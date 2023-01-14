using ConsoleApp1.Factory.BudgetFactory;
using System.Collections.Generic;

namespace ExpenseTrackingApp.Models
{
    public class TrackingPeriod
    {
        private int id;
        private string name;
        private DateTime startDate;
        private DateTime endDate;
        private List<Budget> budgetSchedule;


        public TrackingPeriod(int id, string name, DateTime startDate, DateTime endDate)
        {
            this.id = id;
            this.name = name;
            StartDate = startDate;
            EndDate = endDate;
            StartDate = startDate;
            EndDate = endDate;
            this.budgetSchedule = new List<Budget>();

        }
        public TrackingPeriod()
        {
            this.budgetSchedule = new List<Budget>();

        }

        public int ID { get { return id; } set { id = value; } }
        public DateTime StartDate { get { return startDate; } set { startDate = value; } }
        public DateTime EndDate { get { return endDate; } set { endDate = value; } }

        public void addTrackingPeriod(Budget budgetSchedule) { this.budgetSchedule.Add(budgetSchedule); }


    }
}
