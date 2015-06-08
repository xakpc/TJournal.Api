using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class News
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("mobile_url")]
        public string MobileUrl { get; set; }

        [JsonProperty("preview_img")]
        public string PreviewImg { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("rating")]
        public NewsRating Rating { get; set; }

        [JsonProperty("isFavorited")]
        public bool IsFavorited { get; set; }

        [JsonProperty("date")]
        public int Date { get; set; }
    }
}