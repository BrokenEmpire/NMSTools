using Newtonsoft.Json;
using System;

namespace NMSTools.ConsoleApp
{
    public class ExponentialValueConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(double);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return double.Parse(reader.Value.ToString(), System.Globalization.NumberStyles.Float);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
