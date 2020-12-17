using Newtonsoft.Json;
using System;

namespace NMSTools.Framework.Converters
{
    using Framework.Primitives;

    public sealed class Vector2Converter : JsonConverter
    {
        private readonly int precision;

        public override bool CanConvert(Type objectType) => objectType.Equals(typeof(Vector2));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.StartArray)
                throw new JsonReaderException("Unexpected Token");

            var result = new Vector2
            (
                reader.ReadAsDouble().GetValueOrDefault(0.0),
                reader.ReadAsDouble().GetValueOrDefault(0.0)
            );

            if (!reader.Read())
                throw new JsonReaderException("Unable to read.  Reason Unknown");

            else if (reader.TokenType != JsonToken.EndArray)
                throw new JsonReaderException("Unexpected Token");

            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (!(value is Vector2 vector))
                throw new JsonWriterException("Unexpected object type");

            writer.WriteStartArray();
            writer.WriteRawValue(string.Format("{0:G" + precision + "}", vector[0]).Replace("E", "e"));
            writer.WriteRawValue(string.Format("{0:G" + precision + "}", vector[1]).Replace("E", "e"));
            writer.WriteEndArray();
        }

        public Vector2Converter(int precision = 17) : base() => this.precision = precision;
    }
}
