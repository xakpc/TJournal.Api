using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class PaperAuthor : BaseAuthor
    {
        [JsonProperty("picture_url")]
        public string PictureUrl { get; set; }

        [JsonProperty("picture_big_url")]
        public string PictureBigUrl { get; set; }
    }
}