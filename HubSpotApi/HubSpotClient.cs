using HubSpotApi.Exceptions;
using HubSpotApi.Models.Contacts;
using HubSpotApi.Requests;
using RestSharp;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HubSpotApi
{
    public class HubSpotClient
    {
        private readonly string _apiKey;
        private readonly string _baseURL = "https://api.hubapi.com";
        
        public HubSpotClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        public List<Contact> GetAllContacts()
        {
            ContactsController contControl = new ContactsController(_apiKey, _baseURL);
            return contControl.GetAllContacts();
        }
    }
}
