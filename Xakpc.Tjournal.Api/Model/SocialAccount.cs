using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class SocialAccount
    {
        [JsonProperty("socialId")]
        public long SocialId { get; set; }

        [JsonProperty("socialType")]
        public int SocialType { get; set; }

        [JsonProperty("socialClass")]
        public string SocialClass { get; set; }

        [JsonProperty("screenName")]
        public string ScreenName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}