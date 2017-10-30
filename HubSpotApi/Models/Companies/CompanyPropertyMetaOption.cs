namespace HubSpotApi.Models.Companies
{
    public class CompanyPropertyMetaOption
    {
        /// <summary>
        /// A description of the option
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The label of the option.  The label will be displayed inside the HubSpot app.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Options are displayed in order starting with the lowest positive integer value. Values of -1 will cause the option to be displayed after any positive values.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Hidden options will not be displayed in HubSpot.
        /// </summary>
        public bool Hidden { get; set; }

        /// <summary>
        /// The internal value of the option.  The value of the option must be used when setting the value of the property through the API.
        /// </summary>
        public string Value { get; set; }
    }
}
