using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class PaperAuthor
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("picture_url")]
        public string PictureUrl { get; set; }

        [JsonProperty("picture_big_url")]
        public string PictureBigUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}