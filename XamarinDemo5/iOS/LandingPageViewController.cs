using System;
using UIKit;
using XamarinDemo5.iOS.Adapters;
using XamarinDemo5.Services;

namespace XamarinDemo5.iOS
{
	partial class LandingPageViewController : UIViewController
	{
		public LandingPageViewController (IntPtr handle) : base (handle)
		{
		}

	    public override void ViewDidLoad()
	    {
	        base.ViewDidLoad();

            NavigationController.ViewControllers[0].RemoveFromParentViewController();
            NavigationController.ViewControllers[0] = this;

            NavigationController.SetNavigationBarHidden(false, true);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            // bind every time, to reflect deletion in the Detail view
            var clientService = new ClientService();

            mainListView.Source = new ClientListAdapter(clientService.GetClients());
        }
    }
}
