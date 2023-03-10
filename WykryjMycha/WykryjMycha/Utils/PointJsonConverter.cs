using System.Text.Json.Serialization;
using System.Text.Json;

namespace WykryjMycha
{
    internal class PointJsonConverter : JsonConverter<Point>
    {
        public override Point Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray) throw new JsonException();
            reader.Read();
            float x = (float)reader.GetDecimal();
            reader.Read();
            float y = (float)reader.GetDecimal();
            reader.Read();
            if (reader.TokenType != JsonTokenType.EndArray) throw new JsonException();
            return new Point(x, y);
        }

        public override void Write(Utf8JsonWriter writer, Point value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteNumberValue(value.X);
            writer.WriteNumberValue(value.Y);
            writer.WriteEndArray();
        }
    }
}
