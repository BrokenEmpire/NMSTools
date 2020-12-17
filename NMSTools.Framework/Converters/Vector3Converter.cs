﻿using Newtonsoft.Json;
using System;

namespace NMSTools.Framework.Converters
{
    using Framework.Primitives;

    public sealed class Vector3Converter : BaseConverter<Vector3>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.StartArray)
                throw new JsonReaderException("Unexpected Token");

            var result = new Vector3
            (
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
            if (!(value is Vector3 vector))
                throw new JsonWriterException("Unexpected object type");

            writer.WriteStartArray();

            writer.WriteRawValue(string.Format("{0:G" + precision + "}", vector[0]).Replace("E", "e"));
            writer.WriteRawValue(string.Format("{0:G" + precision + "}", vector[1]).Replace("E", "e"));
            writer.WriteRawValue(string.Format("{0:G" + precision + "}", vector[2]).Replace("E", "e"));

            writer.WriteEndArray();
        }

        public Vector3Converter(int precision = 17) : base(precision) { }
    }
}
