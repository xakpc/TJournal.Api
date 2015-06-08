using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class Author
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("profile_big_image_url")]
        public string ProfileBigImageUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}