using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class InspiredAuthor : PaperAuthor
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("post")]
        public object Post { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("twitter_name")]
        public string TwitterName { get; set; }

        [JsonProperty("google_plus_name")]
        public string GooglePlusName { get; set; }
    }
}