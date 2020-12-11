using Newtonsoft.Json;
using System;

namespace NMSTools.Models.Base
{
    public sealed class FilePathConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType.Equals(typeof(string));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            Console.WriteLine(reader.Value as string);
            return reader.Value as string;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
