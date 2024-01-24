using Arango.VelocyPack.Net.Converters;
using Arango.VelocyPack.Net.Segments.Base;

namespace Arango.VelocyPack.Net.Segments;

public class BooleanSegment : Segment
{
    public override void ParseValue(byte[] data, int startIndex)
    {
        StartIndex = startIndex;
        CursorIndex = startIndex;
        Type = SegmentType.Boolean;
        ValueType = TypeConverter.ToValueType(data[startIndex]);
        ValueStartIndex = StartIndex;
        ValueByteLength = 1;

        // shift cursor index past value type byte
        CursorIndex++;
    }

    public override object LoadValue(byte[] data)
    {
        var value = ValueType switch
        {
            ValueType.False => false,
            ValueType.True => true,
            _ => throw new Exception("Cannot load boolean segment value."),// TODO: throw custom exception
        };
        return value;
    }
}
