// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamarinDemo5.iOS
{
	[Register ("ClientListCell")]
	partial class ClientListCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblClientContact { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblClientName { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lblClientContact != null) {
				lblClientContact.Dispose ();
				lblClientContact = null;
			}
			if (lblClientName != null) {
				lblClientName.Dispose ();
				lblClientName = null;
			}
		}
	}
}
