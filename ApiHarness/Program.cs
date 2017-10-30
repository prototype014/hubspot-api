using HubSpotApi;
using System;
using System.IO;
using System.Net;

namespace ApiHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            string apiKey = "42052a1d-e70d-49ea-bb84-fb292f6c5605";

            HubSpotClient client = new HubSpotClient(apiKey);
            client.GetAllContacts();
        }
    }
}
