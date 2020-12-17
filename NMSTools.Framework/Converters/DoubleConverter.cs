using Newtonsoft.Json;
using System;

namespace NMSTools.Framework.Converters
{
    public sealed class DoubleConverter : BaseConverter<double>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value.ToString() == "0")
                return new double();

            return (double)reader.Value;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var result = string.Format("{0:G" + precision + "}", value).Replace("E", "e");

            if (result.IndexOf('.') < 0)
                writer.WriteRawValue(result + ".0");
            else
                writer.WriteRawValue(result);
        }

        public DoubleConverter(int precision = 17) : base(precision) { }
    }
}
