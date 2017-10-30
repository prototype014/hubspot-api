using System.Collections.Generic;

namespace HubSpotApi.Models.Companies
{
    public class Company
    {
        /// <summary>
        /// The Hub ID that the company belongs to.
        /// </summary>
        public int PortalId { get; set; }

        /// <summary>
        /// The unique ID of the company record.
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// Whether or not the record is deleted. In practice this will always be false as deleted records will not appear in the API.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// A set of objects representing the values for the set company properties. Only populated properties will be included; properties that have never been set for the record will not be included.
        /// </summary>
        public IDictionary<string, CompanyProperty> Properties { get; set; }

        /// <summary>
        /// This is a deprecated field and is not currently used.
        /// </summary>
        public IEnumerable<string> AdditionalDomains { get; set; }
    }
}
