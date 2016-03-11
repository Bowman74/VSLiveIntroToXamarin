
using Xamarin.Forms;
using XamarinDemo7.Views;

namespace XamarinDemo7
{
    public partial class App
    {
        public App()
        {
            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}