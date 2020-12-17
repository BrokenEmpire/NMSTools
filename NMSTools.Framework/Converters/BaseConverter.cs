using Newtonsoft.Json;
using System;

namespace NMSTools.Framework.Converters
{
    public abstract class BaseConverter<T> : JsonConverter
    {
        protected readonly int precision;

        public override bool CanConvert(Type objectType) => objectType.Equals(typeof(T));

        public abstract  override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

        public abstract override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

        protected BaseConverter(int precision = 17) : base() => this.precision = precision;
    }
}
