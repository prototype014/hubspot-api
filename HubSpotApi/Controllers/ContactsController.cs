using HubSpotApi.Models.Contacts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubSpotApi
{
    class ContactsController
    {
        private string _apiKey;
        private string _baseURL;

        public ContactsController(string apiKey, string baseURL)
        {
            _apiKey = apiKey;
            _baseURL = baseURL;
        }

        public List<Contact> GetAllContacts()
        {
            //https://developers.hubspot.com/docs/methods/contacts/get_contacts
            List<Contact> contacts = new List<Contact>();
            string url = _baseURL + "/contacts/v1/lists/all/contacts/all?hapikey=" + _apiKey;
            string response = RequestController.GetRequest(url);
            //deserialise this to a list of contacts
            ClientReturn returned = JsonConvert.DeserializeObject<ClientReturn>(response);
            contacts = returned.contacts;
            return contacts;
        }
    }
}
