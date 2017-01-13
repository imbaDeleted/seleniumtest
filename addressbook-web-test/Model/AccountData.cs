using System.Runtime.CompilerServices;

namespace addressbook_web_test
{
    public class AccountData
    {
        private string _username;
        private string _password;

        public AccountData(string username, string password)
        {
            this._username = username;
            this._password = password;
        }


        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }


        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}