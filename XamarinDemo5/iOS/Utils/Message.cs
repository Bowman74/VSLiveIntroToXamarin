using UIKit;

namespace XamarinDemo5.iOS.Utils
{
    public class Message
    {
        public static void ShowOkMessage(string title, string message)
        {
            using (var alert = new UIAlertView(title, message, null, null, "OK"))
            {
                alert.Show();
            }
        }
    }
}
