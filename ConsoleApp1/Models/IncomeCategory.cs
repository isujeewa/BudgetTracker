using ExpenseTrackingApp.Models;
using System.Transactions;

namespace ExpenseTrackingApp.Factory.Concretes.IncomeCategories
{
    public class IncomeCategory : ICategory
    {
        public IncomeCategory(string id , string name  )
        {
            base.Name = name;
            base.ID = id;
            base.SetCategoryType(CategoryType.Income);
        }
    }
}
