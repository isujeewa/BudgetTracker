using System.Xml.Linq;

namespace ExpenseTrackingApp.Models
{
    public abstract class Category
    {
        private string id;
        private string name;
        private CategoryType categoryType;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public CategoryType CategoryType
        {
            get { return categoryType; }

        }
        public void SetCategoryType(CategoryType categoryType)
        {
            this.categoryType = categoryType;
        }




    }
}
