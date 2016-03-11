﻿using System.Collections.Generic;
using XamarinDemo5.Models;

namespace XamarinDemo5.Services
{
    public class ClientService
    {
        public IList<Client> GetClients()
        {
            var returnList = new List<Client>
            {
                new Client {ClientName = "Microsoft", ContactName = "Satya Nadella"},
                new Client {ClientName = "Xamarin", ContactName = "Miguel de Icaza"},
                new Client {ClientName = "Apple", ContactName = "Tim Cook"},
                new Client {ClientName = "Google", ContactName = "Sundar Pichai"}
            };
            return returnList;
        }
    }
}