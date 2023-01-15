using System.Transactions;

namespace ExpenseTrackingApp.Models
{
    public class ExpenseCategory : Category
    {
        public ExpenseCategory()
        {
            SetCategoryType(CategoryType.Expense);
        }

        public ExpenseCategory(string id, string name)
        {
            base.Name = name;
            base.ID = id;
            base.SetCategoryType(CategoryType.Expense);
        }
    }
}
