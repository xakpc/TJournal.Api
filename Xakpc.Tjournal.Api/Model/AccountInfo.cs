using System.Collections.Generic;
using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class AccountInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("profile_big_image_url")]
        public string ProfileBigImageUrl { get; set; }

        [JsonProperty("profile_background_url")]
        public string ProfileBackgroundUrl { get; set; }

        [JsonProperty("date")]
        public int Date { get; set; }

        [JsonProperty("is_club_member")]
        public bool IsClubMember { get; set; }

        [JsonProperty("rating")]
        public Rating Rating { get; set; }

        [JsonProperty("socialAccounts")]
        public List<SocialAccount> SocialAccounts { get; set; }
    }
}