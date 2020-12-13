using Newtonsoft.Json;
using System;

namespace NMSTools.Models.Base
{
    public sealed class DoubleConverter : JsonConverter
    {
        private readonly int precision;

        public override bool CanConvert(Type objectType)
            => objectType.Equals(typeof(double));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value.ToString() == "0")
                return new double();

            return (double)reader.Value;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var result = string.Format("{0:G" + precision + "}", value);

            if (result.IndexOf('.') < 0)
                writer.WriteRawValue(result + ".0");
            else
                writer.WriteRawValue(result);
        }

        public DoubleConverter(int precision = 16) : base() 
            => this.precision = precision;
    }
}
