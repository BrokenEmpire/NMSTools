using Newtonsoft.Json;
using System;

namespace NMSTools.Models.Base
{
    public sealed class FileNameConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType.Equals(typeof(string));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {

            return existingValue;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

            writer.WriteValue(value);
        }
    }
}
