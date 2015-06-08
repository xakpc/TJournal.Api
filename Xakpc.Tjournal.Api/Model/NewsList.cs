using System.Collections.Generic;
using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class NewsList
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("news")]
        public List<News> News { get; set; }

        [JsonProperty("sources")]
        public List<Source> Sources { get; set; }
    }  
}