using Xamarin.Forms;
using XamarinDemo7.Models;
using XamarinDemo7.Services;

namespace XamarinDemo7.Views
{
    public partial class Landing : ContentPage
    {
        public Landing()
        {
            InitializeComponent();

            Title = "Xamarin Demo";

            var clients = new ClientService();

            lstClientList.ItemsSource = clients.GetClients();

            lstClientList.ItemSelected += LstClientListOnItemSelected;
        }

        private void LstClientListOnItemSelected(object sender, SelectedItemChangedEventArgs selectedItemChangedEventArgs)
        {
            if (selectedItemChangedEventArgs.SelectedItem == null)
            {
                return; 
            }

            var client = (Client)selectedItemChangedEventArgs.SelectedItem;
            
            DisplayAlert("Item Selected", $"Clicked on {client.ClientName}", "Ok");
            ((ListView)sender).SelectedItem = null; 
        }
    }
}