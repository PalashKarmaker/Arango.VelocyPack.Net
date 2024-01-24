﻿using Arango.VelocyPack.Net.Converters;
using Arango.VelocyPack.Net.Segments.Base;

namespace Arango.VelocyPack.Net.Segments
{
    public class NullSegment : Segment
    {
        public override void ParseValue(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.Null;
            ValueType = TypeConverter.ToValueType(data[startIndex]);
            ValueStartIndex = StartIndex;
            ValueByteLength = 1;

            // shift cursor index past value type byte
            CursorIndex++;
        }

        public override object LoadValue(byte[] data)
        {
            return null;
        }
    }
}
