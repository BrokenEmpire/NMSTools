using Newtonsoft.Json;
using System;

namespace NMSTools.Framework.Base
{
    public abstract class ConverterBase<T> : JsonConverter
    {
        protected readonly int precision;

        public override bool CanConvert(Type objectType) => objectType.Equals(typeof(T));

        public abstract override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

        public abstract override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

        protected virtual string Format(string value)
        {
            var result = value;

            if (result.IndexOf('.') < 0)
                result += ".0";

            return result;
        }

        protected virtual string Format(double value) => Format(string.Format("{0:g" + precision + "}", value));

        protected virtual string Format(object value) => Format(string.Format("{0:g" + precision + "}", value));

        protected ConverterBase(int precision = 18) : base() => this.precision = precision;
    }
}
