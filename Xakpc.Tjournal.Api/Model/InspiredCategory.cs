using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class InspiredCategory : PaperCategory
    {
        [JsonProperty("class")]
        public string Class { get; set; }
    }
}