using System;
using UIKit;

namespace XamarinDemo6.iOS
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
