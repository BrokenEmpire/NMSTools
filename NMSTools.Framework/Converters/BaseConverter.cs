using Newtonsoft.Json;
using System;

namespace NMSTools.Framework.Converters
{
    public abstract class BaseConverter<T> : JsonConverter
    {
        protected readonly int precision;
        protected static char[] exponentKeys = new char[2] { 'E','e' };

        public override bool CanConvert(Type objectType) => objectType.Equals(typeof(T));

        public abstract override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

        public abstract override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

        protected virtual string Format(string value)
        {
            var result = value;

            if (result.IndexOfAny(exponentKeys) > 0)
                result = result.Replace("E", "e");

            if (result.IndexOf('.') < 0)
                result += ".0";

            return result;
        }

        protected virtual string Format(double value) => Format(string.Format("{0:G" + precision + "}", value));

        protected virtual string Format(object value) => Format(string.Format("{0:G" + precision + "}", value));

        protected BaseConverter(int precision = 18) : base() => this.precision = precision;
    }
}
