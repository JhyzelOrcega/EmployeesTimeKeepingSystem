using System;

namespace ClassLibrary2.DL
{
    public class Class1
    {
        private string username;
        private string password;

        public Users(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }
    }
}

