using System;
using Newtonsoft.Json;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api.DAL
{
    /// <summary>
    /// 
    /// </summary>
    public class InspiredByThisJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
                return reader.Value;

            return reader.Value.Equals("false") ? null : serializer.Deserialize<InspiredPaper>(reader);
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}