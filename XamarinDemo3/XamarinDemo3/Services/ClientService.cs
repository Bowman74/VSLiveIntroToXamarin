using System.Collections.Generic;
using XamarinDemo3.Models;

namespace XamarinDemo3.Services
{
    public class ClientService
    {
        public IList<Client> GetClients()
        {
            var returnList = new List<Client>();
            returnList.Add(new Client {ClientName = "Microsoft", ContactName = "Satya Nadella" });
            returnList.Add(new Client {ClientName = "Xamarin", ContactName = "Miguel de Icaza" });
            returnList.Add(new Client { ClientName = "Apple", ContactName = "Tim Cook" });
            returnList.Add(new Client { ClientName = "Google", ContactName = "Sundar Pichai" });
            return returnList;
        }
    }
}
