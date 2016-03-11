using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamarinDemo5.iOS
{
	partial class ClientListCell : UITableViewCell
	{
		public ClientListCell (IntPtr handle) : base (handle)
		{
		}

	    public void SetCellContents(string clientName, string clientContact)
	    {
	        lblClientName.Text = clientName;
	        lblClientContact.Text = clientContact;
	    }
	}
}
