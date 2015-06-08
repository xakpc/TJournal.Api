using System.Collections.Generic;
using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class ClubPaper : BasePaper
    {
        [JsonProperty("intro")]
        public string Intro { get; set; }

        [JsonProperty("cover_image_url")]
        public object CoverImageUrl { get; set; }

        [JsonProperty("cover_image_size")]
        public object CoverImageSize { get; set; }

        [JsonProperty("entry")]
        public string Entry { get; set; }

        [JsonProperty("media")]
        public List<Medium> Media { get; set; }

        [JsonProperty("likes")]
        public Likes Likes { get; set; }

        [JsonProperty("external_link_domain")]
        public string ExternalLinkDomain { get; set; }

        [JsonProperty("inspiredByThis")]
        public bool InspiredByThis { get; set; }
    }
}