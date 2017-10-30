using System;
using System.Collections.Generic;

namespace HubSpotApi.Models.Companies
{
    public class CompanyPropertyMeta
    {
        /// <summary>
        /// The internal name of the property. The name should always be used when referencing the property through the API.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A human readable label for the property. The label is used when displaying the property in the HubSpot app.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// A human readable label for the property. The label is used when displaying the property in the HubSpot app.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A description of the property. May be an empty string.
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// String, one of string, number, date, datetime, or enumeration. The data type of the property. See https://developers.hubspot.com/docs/methods/companies/create_company_property for more details.
        /// </summary>
        public string Type { get; set; }

        [Obsolete("This field currently has no use as company properties cannot be used in forms.")]
        public string FieldType { get; set; }

        /// <summary>
        /// The internal user ID of the last user to update the property in the HubSpot app. This field may not exist if the property was never modified inside HubSpot.
        /// </summary>
        public int UpdatedUserId { get; set; }

        /// <summary>
        /// Whether or not the property is deleted. This will effectively always be false, as deleted properties will not appear in the API.
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// A list of valid options for the property. Required for enumerated properties. This list will be empty for other property types.
        /// </summary>
        public IEnumerable<CompanyPropertyMetaOption> Options { get; set; }
    }
}
