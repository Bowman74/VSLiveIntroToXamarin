using System;
using Foundation;
using UIKit;

namespace XamarinDemo4.iOS
{
	partial class LandingPageViewController_ : UIViewController
	{
		public LandingPageViewController_ (IntPtr handle) : base (handle)
		{
		}

	    public override void ViewDidLoad()
	    {
	        base.ViewDidLoad();

            NavigationController.ViewControllers[0].RemoveFromParentViewController();
            NavigationController.ViewControllers[0] = this;

            NavigationController.SetNavigationBarHidden(false, true);

            webViewLanding.LoadRequest(new NSUrlRequest(new NSUrl("https://www.google.com")));

        }
	}
}
