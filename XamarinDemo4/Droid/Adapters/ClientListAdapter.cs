using System.Collections.Generic;

using Android.App;
using Android.Views;
using Android.Widget;
using XamarinDemo4.Models;

namespace XamarinDemo4.Droid.Adapters
{
    public class ClientListAdapter : BaseAdapter<Client>
    {
        IList<Client> _clients;
        Activity _context;
        public ClientListAdapter(Activity context, IList<Client> clients)
        {
            _context = context;
            _clients = clients;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Client this[int position] => _clients[position];

        public override int Count => _clients.Count;

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if (view == null)
            {
                view = _context.LayoutInflater.Inflate(Resource.Layout.ClientRow, null);
            }
            view.FindViewById<TextView>(Resource.Id.lblClientName).Text = _clients[position].ClientName;
            view.FindViewById<TextView>(Resource.Id.lblClientContact).Text = _clients[position].ContactName;
            return view;
        }
    }
}