using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class Source
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }
    }
}