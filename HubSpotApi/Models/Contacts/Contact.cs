using HubSpotApi.Models.Contacts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubSpotApi.Models.Contacts
{
    public class Firstname
    {
        public string value { get; set; }
    }

    public class Lastmodifieddate
    {
        public string value { get; set; }
    }

    public class Lastname
    {
        public string value { get; set; }
    }

    public class Properties
    {
        public Firstname firstname { get; set; }
        public Lastmodifieddate lastmodifieddate { get; set; }
        public Lastname lastname { get; set; }
    }

    public class Identity
    {
        public string type { get; set; }
        public string value { get; set; }
        public object timestamp { get; set; }
    }

    public class IdentityProfile
    {
        public int vid { get; set; }
        public List<Identity> identities { get; set; }
    }

    public class Contact
    {
        public object addedAt { get; set; }
        public int vid { get; set; }
        [JsonProperty(PropertyName = "canonical-vid")]
        public int canonical_vid { get; set; }
        [JsonProperty(PropertyName = "merged-vids")]
        public List<object> merged_vids { get; set; }
        [JsonProperty(PropertyName = "portal-id")]
        public int portal_id { get; set; }
        [JsonProperty(PropertyName = "is-contact")]
        public bool is_contact { get; set; }
        [JsonProperty(PropertyName = "profile-token")]
        public string profile_token { get; set; }
        [JsonProperty(PropertyName = "profile-url")]
        public string profile_url { get; set; }
        public Properties properties { get; set; }
        [JsonProperty(PropertyName = "form-submissions")]
        public List<object> form_submissions { get; set; }
        [JsonProperty(PropertyName = "identity-profiles")]
        public List<IdentityProfile> identity_profiles { get; set; }
        [JsonProperty(PropertyName = "merge-audits")]
        public List<object> merge_audits { get; set; }
    }

    public class ClientReturn
    {
        public List<Contact> contacts { get; set; }
        [JsonProperty(PropertyName = "has-more")]
        public bool has_more { get; set; }
        [JsonProperty(PropertyName = "vid-offset")]
        public int vid_offset { get; set; }
    }
}