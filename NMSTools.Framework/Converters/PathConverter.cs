using Newtonsoft.Json;
using System;

namespace NMSTools.Framework.Converters
{
    public sealed class PathConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
            => objectType.Equals(typeof(string));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            => reader.Value as string;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            switch (value)
            {
                case string s:
                    if (s.EndsWith(".MBIN"))
                        writer.WriteRawValue((char)34 + s.Replace("/", @"\/") + (char)34);
                    else
                        writer.WriteValue(s);

                    return;

                default:
                    throw new Exception("Invalid Type");
            };
        }
    }
}
