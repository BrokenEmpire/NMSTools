using Newtonsoft.Json;
using System;

namespace NMSTools.Framework.Converters
{
    using Base;
    using Framework.Primitives;

    public sealed class Vector4Converter : ConverterBase<Vector4>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.StartArray)
                throw new JsonReaderException("Unexpected Token");

            var result = new Vector4
            (
                reader.ReadAsDouble().GetValueOrDefault(0.0),
                reader.ReadAsDouble().GetValueOrDefault(0.0),
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
            if (!(value is Vector4 vector))
                throw new JsonWriterException("Unexpected object type");

            writer.WriteStartArray();
            writer.WriteRawValue(Format(vector[0]));
            writer.WriteRawValue(Format(vector[1]));
            writer.WriteRawValue(Format(vector[2]));
            writer.WriteRawValue(Format(vector[3]));
            writer.WriteEndArray();
        }

        public Vector4Converter(int precision = 18) : base(precision) { }
    }
}
