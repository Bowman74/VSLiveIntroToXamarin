using System;

namespace XamarinDemo2
{
    public class LoginService
    {
        public LoginService()
        {
        }

        public bool Login(string userName, string password)
        {
            return userName == "Test" && password == "Password";
        }
    }
}

