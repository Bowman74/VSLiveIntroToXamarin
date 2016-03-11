using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using XamarinDemo5.Models;

namespace XamarinDemo5.iOS.Adapters
{
    public class ClientListAdapter : UITableViewSource
    {
        private readonly IList<Client> _clients;
        private string cellIdentifier = "ClientListCell";

        public ClientListAdapter(IList<Client> clients)
        {
            _clients = clients;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _clients.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            // in a Storyboard, Dequeue will ALWAYS return a cell,
            var cell = (ClientListCell)tableView.DequeueReusableCell(cellIdentifier);
            // now set the properties as normal
            cell.SetCellContents(_clients[indexPath.Row].ClientName, _clients[indexPath.Row].ContactName);
            return cell;
        }

        public Client GetItem(nint id)
        {
            return _clients[Convert.ToInt32(id)];
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var client = _clients[indexPath.Row];
            Utils.Message.ShowOkMessage("Item Clicked", $"Clicked on {client.ClientName}");
            tableView.DeselectRow(indexPath, true);
        }
    }
}