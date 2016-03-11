
using Android.App;
using Android.OS;
using Android.Webkit;

namespace XamarinDemo2.Droid
{
    [Activity(Label = "XamarinDemo2",
        Icon = "@mipmap/ic_launcher",
        Theme = "@style/MyTheme")]
    public class LandingPageActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.LandingPage);

            var webView = FindViewById<WebView>(Resource.Id.mainWebView);
            webView.SetWebViewClient(new LocalWebView());
            webView.LoadUrl("http://www.google.com");
        }
    }

    public class LocalWebView : WebViewClient
    {
        public override bool ShouldOverrideUrlLoading(WebView view, string url)
        {
            return base.ShouldOverrideUrlLoading(view, url);
        }
    }
}