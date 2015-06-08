using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class User
    {
        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("followers_count")]
        public int FollowersCount { get; set; }

        [JsonProperty("friends_count")]
        public int FriendsCount { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("profile_image_url_bigger")]
        public string ProfileImageUrlBigger { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("statuses_count")]
        public int StatusesCount { get; set; }
    }
}