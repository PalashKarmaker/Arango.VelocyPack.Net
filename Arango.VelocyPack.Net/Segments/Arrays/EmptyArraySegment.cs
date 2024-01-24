using Arango.VelocyPack.Net.Converters;

namespace Arango.VelocyPack.Net.Segments
{
    public class EmptyArraySegment : ArraySegment
    {
        public override void ParseValue(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.EmptyArray;
            ValueType = TypeConverter.ToValueType(data[startIndex]);
            ValueStartIndex = StartIndex;
            ValueByteLength = 1;
            Items = [];

            // shift cursor index past value type byte
            CursorIndex++;
        }

        public override object LoadValue(byte[] data)
        {
            return new List<object>();
        }
    }
}
