using System;
using Android.App;
using Android.Widget;
using Android.OS;
using XamarinDemo4.Services;

namespace XamarinDemo4.Droid
{
    [Activity(Label = "XamarinDemo4",
        Theme = "@android:style/Theme.Holo.Light.NoActionBar.Fullscreen",
        NoHistory = true)]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" resource
            SetContentView(Resource.Layout.LoginLinear);

            var btnLogin = this.FindViewById<Button>(Resource.Id.btnLogin);

            btnLogin.Click += BtnLoginOnClick;
        }

        private void BtnLoginOnClick(object sender, EventArgs eventArgs)
        {
            var loginService = new LoginService();
            var txtUserName = FindViewById<EditText>(Resource.Id.txtUserName);
            var txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);

            if (loginService.Login(txtUserName.Text, txtPassword.Text))
            {
                StartActivity(typeof(LandingPageActivity));
            }
            else
            {
                Utils.Message.ShowOkMessage(this, "Login Failure", "Invalid username or password");
            }
        }
    }
}