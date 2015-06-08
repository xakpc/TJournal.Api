using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class Medium
    {
        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("media_url")]
        public string MediaUrl { get; set; }

        [JsonProperty("thumbnail_width")]
        public int ThumbnailWidth { get; set; }

        [JsonProperty("thumbnail_height")]
        public int ThumbnailHeight { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }
    }
}