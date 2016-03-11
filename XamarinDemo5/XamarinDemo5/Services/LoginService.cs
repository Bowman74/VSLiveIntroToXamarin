
namespace XamarinDemo5.Services
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

