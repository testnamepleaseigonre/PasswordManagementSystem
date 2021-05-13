namespace PasswordManagementSystem.Models
{
    public class Entry
    {
        private string login;
        private string pass;
        private string url_app;
        private string more;

        public Entry(string login, string pass, string url_app, string more)
        {
            this.login = login;
            this.pass = pass;
            this.url_app = url_app;
            this.more = more;
        }

        public string getLogin()
        {
            return login;
        }

        public string getPass()
        {
            return pass;
        }

        public string getUrlApp()
        {
            return url_app;
        }

        public string getMore()
        {
            return more;
        }

        public void  setPass(string pass)
        {
            this.pass = pass;
        }

        public string  toString()
        {
            return $"{getLogin()},{getPass()},{getUrlApp()},{getMore()}";
        }
    }
}
