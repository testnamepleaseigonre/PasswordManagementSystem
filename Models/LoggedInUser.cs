namespace PasswordManagementSystem.Models
{
    public class LoggedInUser
    {
        private string username;
        private string password;
        private string id;

        public LoggedInUser(string id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }
        public string getId()
        {
            return id;
        }
    }
}
