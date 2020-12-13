using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace NMSTools.Models.Base
{
    public sealed class TerrainDataConverter : JsonConverter
    {
        private readonly int precision;

        public override bool CanConvert(Type objectType)
            => objectType.Equals(typeof(object));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var result = new List<decimal[]>();

            if (reader.TokenType != JsonToken.StartArray)
                throw new JsonReaderException("Unexpected Token");

            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.StartArray)
                    continue;

                if (reader.TokenType == JsonToken.EndArray)
                    break;

                var array = new decimal[3];

                for (int i = 0; i < array.Length; i++)
                {
                    var tmp = (double)reader.Value;

                    array[i] = (decimal)double.Parse(reader.Value.ToString(), NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture);

                    reader.Read();
                }

                result.Add(array);
            }

            if (reader.TokenType != JsonToken.EndArray)
                throw new JsonReaderException("Unexpected Token");

            return result.ToArray();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var array = (decimal[][])value;

            writer.WriteStartArray();

            for (var i = 0; i < array.Length; i++)
            {
                writer.WriteStartArray();

                for (int n = 0; n < array[i].Length; n++)
                {
                    var result = string.Format("{0:G" + precision + "}", array[i][n]);

                    if (result.IndexOf('.') < 0)
                        writer.WriteRawValue(result + ".0");
                    else
                        writer.WriteRawValue(result);
                }
                
                writer.WriteEndArray();
            }

            writer.WriteEndArray();
        }

        public TerrainDataConverter() : this(17) { }

        public TerrainDataConverter(int precision) : base()
            => this.precision = precision;
    }
}
