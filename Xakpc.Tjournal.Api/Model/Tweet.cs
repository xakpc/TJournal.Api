using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class Tweet
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("retweet_count")]
        public int RetweetCount { get; set; }

        [JsonProperty("favorite_count")]
        public int FavoriteCount { get; set; }

        [JsonProperty("has_media")]
        public bool HasMedia { get; set; }

        [JsonProperty("media")]
        public object Media { get; set; }

        [JsonProperty("isFavorited")]
        public bool IsFavorited { get; set; }

        [JsonProperty("security_user_hash")]
        public string SecurityUserHash { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }
    }
}