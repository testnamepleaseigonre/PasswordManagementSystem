
namespace PasswordManagementSystem.Models
{
    class NewUser
    {
        private string username;
        private string password;

        public NewUser( string username, string password)
        {
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
    }
}
