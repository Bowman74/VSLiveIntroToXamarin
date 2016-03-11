using System;
using Foundation;
using UIKit;
using XamarinDemo5.Services;

namespace XamarinDemo5.iOS
{
    public partial class LoginViewController : UIViewController
    {
        public LoginViewController(IntPtr handle)
            : base(handle)
        {        
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationController.SetNavigationBarHidden(true, true);

            txtUserName.ShouldReturn += ShouldReturn;
            txtPassword.ShouldReturn += ShouldReturn;
        }

        private bool ShouldReturn(UITextField textField)
        {
            if (textField.Equals(txtPassword))
            {
                txtPassword.ResignFirstResponder();
            } 
            else if (textField.Equals(txtUserName))
            {
                txtPassword.BecomeFirstResponder();
            }
            return true;
        }

        public override bool ShouldPerformSegue(string segueIdentifier, NSObject sender)
        {
            if (segueIdentifier == "sguShowLandingPage")
            {
                var loginService = new LoginService();

                if (loginService.Login(txtUserName.Text, txtPassword.Text))
                {
                    return true;
                }
                Utils.Message.ShowOkMessage("Login Failure", "Invalid username or password");
                return false;
            }
            return base.ShouldPerformSegue(segueIdentifier, sender);
        }

        public override void DidReceiveMemoryWarning()
        {        
            base.DidReceiveMemoryWarning();        
            // Release any cached data, images, etc that aren't in use.        
        }
    }
}