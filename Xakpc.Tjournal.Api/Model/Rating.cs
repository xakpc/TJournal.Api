using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class Rating
    {
        [JsonProperty("karma")]
        public double Karma { get; set; }

        [JsonProperty("karmaCount")]
        public int KarmaCount { get; set; }
    }
}