using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class Likes
    {
        [JsonProperty("summ")]
        public int Summ { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("is_liked")]
        public bool IsLiked { get; set; }

        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }
    }
}