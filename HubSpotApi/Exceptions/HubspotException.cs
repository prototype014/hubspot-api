using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubSpotApi.Exceptions
{
    [Serializable]
    public class HubspotException : Exception
    {
        public HubspotException() { }
        public HubspotException(string message) : base(message) { }
        public HubspotException(string message, Exception inner) : base(message, inner) { }
        protected HubspotException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}