using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    /// <summary>
    /// Базовый класс статьи
    /// </summary>
    public class BasePaper
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("external_link")]
        public object ExternalLink { get; set; }

        [JsonProperty("external_link_wrapped")]
        public object ExternalLinkWrapped { get; set; }

        [JsonProperty("author")]
        public PaperAuthor Author { get; set; }

        [JsonProperty("comments_count")]
        public int CommentsCount { get; set; }

        [JsonProperty("hits")]
        public int Hits { get; set; }

        [JsonProperty("category")]
        public PaperCategory Category { get; set; }

        [JsonProperty("isFavorited")]
        public bool IsFavorited { get; set; }

        [JsonProperty("date")]
        public int Date { get; set; }
    }
}