using Android.App;

namespace XamarinDemo5.Droid.Utils
{
    public class Message
    {
        public static void ShowOkMessage(Activity activity, string title, string message)
        {
            var alert = new AlertDialog.Builder(activity);
            alert.SetTitle(title);
            alert.SetMessage(message);
            alert.SetNegativeButton("OK", (o, args) => { });
            alert.Show();
        }
    }
}