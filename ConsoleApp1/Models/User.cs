namespace ExpenseTrackingApp.Models
{
    public class User
    {
        //id of the user
        private int id;
        //name of the user
        private string name;
        //password of the user
        private string pwd;
        //determine whether user is active or not 
        private bool active;

        //User constructor 
        public User(int id, string name , string pwd, bool active) {
            this.id = id;
            this.name = name;
            this.pwd = pwd;
            this.active = active;
        }
    }
}
