using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class NewsRating
    {
        [JsonProperty("vk")]
        public int Vk { get; set; }
        [JsonProperty("twitter")]
        public int Twitter { get; set; }
        [JsonProperty("fb")]
        public int Fb { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("superTotal")]
        public int SuperTotal { get; set; }
    }
}