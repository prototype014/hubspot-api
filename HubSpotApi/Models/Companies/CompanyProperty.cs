using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HubSpotApi.Models.Companies
{
    public class CompanyProperty
    {
        /// <summary>
        /// The internal name of the property.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// A Unix timestamp (in milliseconds) of the time the property was last set.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long TimestampEpoch { get; set; }

        /// <summary>
        /// The method by which the value was set. See https://developers.hubspot.com/docs/methods/contacts/contacts-overview#sourcetype for more details.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Additional details for the source of the change. This may not be set for all source types.
        /// </summary>
        public string SourceId { get; set; }

        /// <summary>
        /// A list of previous versions of the property. The first item in the list will be the current version.
        /// </summary>
        public IEnumerable<CompanyPropertyVersion> Versions { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => TimestampEpoch.FromUnixTimeMilliseconds();
    }
}
