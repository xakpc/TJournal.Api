using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class Author : BaseAuthor
    {
        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("profile_big_image_url")]
        public string ProfileBigImageUrl { get; set; }
    }
}