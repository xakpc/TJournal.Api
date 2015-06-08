using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class Paper : BasePaper
    {
        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("display_type")]
        public int DisplayType { get; set; }

        [JsonProperty("is_commentsClosed")]
        public bool IsCommentsClosed { get; set; }

        [JsonProperty("is_advertisment")]
        public bool IsAdvertisment { get; set; }

        [JsonProperty("is_realtimeClosed")]
        public bool IsRealtimeClosed { get; set; }

        [JsonProperty("picture_url")]
        public string PictureUrl { get; set; }

        [JsonProperty("picture_big_url")]
        public string PictureBigUrl { get; set; }

        [JsonProperty("picture_png_preview_url")]
        public object PicturePngPreviewUrl { get; set; }

        [JsonProperty("picture_url_original")]
        public string PictureUrlOriginal { get; set; }

        [JsonProperty("picture_big_url_original")]
        public string PictureBigUrlOriginal { get; set; }
    }
}