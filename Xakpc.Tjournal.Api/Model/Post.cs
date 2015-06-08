using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class Post
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("intro")]
        public string Intro { get; set; }

        [JsonProperty("cover_image_url")]
        public string CoverImageUrl { get; set; }

        [JsonProperty("cover_image_size")]
        public string CoverImageSize { get; set; }

        [JsonProperty("entry")]
        public string Entry { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("media")]
        public object Media { get; set; }

        [JsonProperty("comments_count")]
        public int CommentsCount { get; set; }

        [JsonProperty("hits")]
        public int Hits { get; set; }

        [JsonProperty("likes")]
        public Likes Likes { get; set; }

        [JsonProperty("external_link")]
        public string ExternalLink { get; set; }

        [JsonProperty("external_link_domain")]
        public string ExternalLinkDomain { get; set; }

        [JsonProperty("external_link_wrapped")]
        public string ExternalLinkWrapped { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("inspiredByThis")]
        public bool InspiredByThis { get; set; }

        [JsonProperty("isFavorited")]
        public bool IsFavorited { get; set; }

        [JsonProperty("date")]
        public int Date { get; set; }
    }
}