using Android.App;
using Android.OS;
using Android.Widget;
using XamarinDemo5.Droid.Adapters;
using XamarinDemo5.Services;

namespace XamarinDemo5.Droid
{
    [Activity(Label = "XamarinDemo5",
        Icon = "@mipmap/ic_launcher",
        Theme = "@style/MyTheme")]
    public class LandingPageActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.LandingPageList);

            var listView = FindViewById<ListView>(Resource.Id.mainListView);

            var clientService = new ClientService();
            var listAdapter = new ClientListAdapter(this, clientService.GetClients());
            listView.Adapter = listAdapter;
            listView.ItemClick += ListViewOnItemClick;
        }

        private void ListViewOnItemClick(object sender, AdapterView.ItemClickEventArgs itemClickEventArgs)
        {
            var index = itemClickEventArgs.Position;
            var listView = FindViewById<ListView>(Resource.Id.mainListView);
            var adapter = (ClientListAdapter)listView.Adapter;

            var client = adapter[index];

            Utils.Message.ShowOkMessage(this, "Item Clicked", $"Clicked on {client.ClientName}");
        }
    }
}