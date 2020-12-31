using Newtonsoft.Json;
using System;

namespace NMSTools.Framework.Converters
{
    using Base;

    public sealed class DoubleConverter : ConverterBase<double>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value.ToString() == "0")
                return new double();

            return (double)reader.Value;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue(Format(value));
        }

        public DoubleConverter(int precision = 18) : base(precision) { }
    }
}
