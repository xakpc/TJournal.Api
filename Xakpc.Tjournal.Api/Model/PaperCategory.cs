using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class PaperCategory : Category
    {
        [JsonProperty("isShowInGrid")]
        public bool IsShowInGrid { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }
    }
}