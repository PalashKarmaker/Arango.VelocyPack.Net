﻿using Arango.VelocyPack.Net.Converters;
using Arango.VelocyPack.Net.Segments;

namespace Arango.VelocyPack.Net;

public class VPack
{
    public static Segment ToSegment(byte[] data) => ToSegment(data, 0);

    public static Segment ToSegment(byte[] data, int startIndex)
    {
        var segmentType = TypeConverter.ToSegmentType(data[startIndex]);
        Segment segment = null;

        switch (segmentType)
        {
            case SegmentType.None:
                segment = new NoneSegment();
                break;
            case SegmentType.EmptyArray:
                segment = new EmptyArraySegment();
                break;
            case SegmentType.NonIndexedArray:
                segment = new NonIndexedArraySegment();
                break;
            case SegmentType.CompactArray:
                segment = new CompactArraySegment();
                break;
            case SegmentType.Illegal:
                segment = new IllegalSegment();
                break;
            case SegmentType.Null:
                segment = new NullSegment();
                break;
            case SegmentType.Boolean:
                segment = new BooleanSegment();
                break;
            case SegmentType.Float:
                segment = new FloatSegment();
                break;
            case SegmentType.Double:
                segment = new DoubleSegment();
                break;
            case SegmentType.NonSensical:
                segment = new NonSensicalSegment();
                break;
            case SegmentType.SmallInteger:
                segment = new SmallIntegerSegment();
                break;
            case SegmentType.SignedInteger:
                segment = new SignedIntegerSegment();
                break;
            case SegmentType.UnsignedInteger:
                segment = new UnsignedIntegerSegment();
                break;
            case SegmentType.IndexedArray:
                break;
            case SegmentType.Object:
                break;
            case SegmentType.String:
                break;
            case SegmentType.Blob:
                break;
            case SegmentType.External:
                break;
            case SegmentType.DateTime:
                break;
            case SegmentType.Custom:
                break;
            case SegmentType.Miscellaneous:
                break;
            default:
                // TODO: throw custom exception
                throw new Exception("Segment type is not implemented.");
        }

        segment.ParseValue(data, startIndex);

        return segment;
    }

    public static T ToSegment<T>(byte[] data) where T : Segment
    {
        return (T)ToSegment(data);
    }

    public static T ToObject<T>(byte[] data)
    {
        // TODO: correct List<T> deserialization
        return (T)ToSegment(data).LoadValue(data);
    }
}
