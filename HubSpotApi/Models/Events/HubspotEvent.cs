using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HubSpotApi.Models.Events
{
    public class HubspotEvent
    {
        /// <summary>
        /// The unique id of the task
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The hub id
        /// </summary>
        public string PortalId { get; set; }

        /// <summary>
        /// When the event is/ was scheduled to be published, in milliseconds since the epoch
        /// </summary>
        [JsonProperty(PropertyName = "eventDate")]
        public long EventEpoch { get; set; }

        /// <summary>
        /// Type of calendar event; for tasks this is PUBLISHING_TASK, for COS Items, this is CONTENT, for social media events, this is SOCIAL
        /// </summary>
        public string EventType { get; set; }

        /// <summary>
        /// Type of event; one of email, recurring-email, blog-post, landing-page, legacy-page, site-page
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// One of 2 (email, recurring-email), 3 (blog-post), 1 (landing-page), 5 (legacy-page), 4 (site-page)
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Id value of the COS content object associated with the event, null for if nothing associated
        /// </summary>
        public long ContentId { get; set; }

        /// <summary>
        /// One of SCHEDULED, PUBLISHED, PUBLISHED_OR_SCHEDULED
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Value of campaign GUID associated with Content
        /// </summary>
        public string CampaignGuid { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public long ContentGroupId { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public IEnumerable<long> TopicIds { get; set; }

        /// <summary>
        /// Name of Event
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of Event
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Public URL of content item
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public long OwnerId { get; set; }

        /// <summary>
        /// HubSpot id of the user that the event was created by
        /// </summary>
        public long CreatedBy { get; set; }

        /// <summary>
        /// Preview key of content object; used for showing previews of unpublished items.
        /// </summary>
        public string PreviewKey { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public string SocialUserName { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public string SocialDisplayName { get; set; }

        /// <summary>
        /// Reserved
        /// </summary>
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Is the event recurring?
        /// </summary>
        public bool Recurring { get; set; }

        [JsonIgnore]
        public DateTime EventDate => EventEpoch.FromUnixTimeMilliseconds();
    }
}