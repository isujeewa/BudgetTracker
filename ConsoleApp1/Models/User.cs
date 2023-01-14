namespace ExpenseTrackingApp.Models
{
    public class User
    {
        //id of the user
        public string id { get; set; }
        //name of the user
        public string name { get; set; }
        //password of the user { get; set; }
        //determine whether user is active or not 
        public bool active { get; set; }
        public string pwd { get; set; }


        //User constructor 
        public User(string id, string name , string pwd, bool active) {
            this.id = id;
            this.name = name;
            this.pwd = pwd;
            this.active = active;
        }
    }
}
