using Newtonsoft.Json;

namespace Xakpc.Tjournal.Api.Model
{
    public class InspiredPaper : Paper
    {
       

        [JsonProperty("description")]
        public string Description { get; set; }

       

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        

        [JsonProperty("type")]
        public string Type { get; set; }

       

        [JsonProperty("is_stillWriting")]
        public string IsStillWriting { get; set; }

       

        [JsonProperty("is_withheld")]
        public object IsWithheld { get; set; }

        [JsonProperty("inspiredBy")]
        public string InspiredBy { get; set; }

        [JsonProperty("access_level")]
        public string AccessLevel { get; set; }

        [JsonProperty("yanews_export")]
        public string YanewsExport { get; set; }

        

        [JsonProperty("date_rfc")]
        public string DateRfc { get; set; }

        [JsonProperty("preferred_title")]
        public string PreferredTitle { get; set; }

        [JsonProperty("raw_description")]
        public string RawDescription { get; set; }

        [JsonProperty("hits_beauty")]
        public string HitsBeauty { get; set; }

        [JsonProperty("mobile_app_url")]
        public string MobileAppUrl { get; set; }

        [JsonProperty("display_class")]
        public string DisplayClass { get; set; }

        [JsonProperty("picture_biggest_url")]
        public string PictureBiggestUrl { get; set; }        
    }
}