using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class PaperWrapper
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("data")]
        public Paper Data { get; set; }

        [JsonProperty("sectionRelated")]
        public int SectionRelated { get; set; }
    }
}