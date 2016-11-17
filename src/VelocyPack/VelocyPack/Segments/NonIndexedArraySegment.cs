﻿using System;
using System.Collections.Generic;

namespace VelocyPack.Segments
{
    public class NonIndexedArraySegment : Segment
    {
        public override void Load(byte[] data, int startIndex)
        {
            StartIndex = startIndex;
            CursorIndex = startIndex;
            Type = SegmentType.NonIndexedArray;
            ValueType = TypeMapper.ToValueType(data[startIndex]);
            SubSegments = new List<Segment>();

            switch (ValueType)
            {
                case ValueType.OneByteNonIndexedArray:
                case ValueType.TwoByteNonIndexedArray:
                case ValueType.FourByteNonIndexedArray:
                case ValueType.EightByteNonIndexedArray:
                case ValueType.CompactNonIndexedArray:
                    ParseNonIndexedArray(data);
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("Data does not contain non indexed array segment.");
            }
        }

        // 0x02 : array without index table (all subitems have the same byte length), 1-byte byte length
        // 0x03 : array without index table (all subitems have the same byte length), 2-byte byte length
        // 0x04 : array without index table (all subitems have the same byte length), 4-byte byte length
        // 0x05 : array without index table (all subitems have the same byte length), 8-byte byte length
        private void ParseNonIndexedArray(byte[] data)
        {
            // shift cursor index past value type byte
            CursorIndex++;

            long byteLength;

            // each case performs the following:
            // - parse byte length
            // - shift cursor index past byte lenght byte(s)
            switch (ValueType)
            {
                case ValueType.OneByteNonIndexedArray:
                    byteLength = data[CursorIndex];
                    CursorIndex++;
                    break;
                case ValueType.TwoByteNonIndexedArray:
                    byteLength = BitConverter.ToInt16(data, CursorIndex);
                    CursorIndex += 2;
                    break;
                case ValueType.FourByteNonIndexedArray:
                    byteLength = BitConverter.ToInt32(data, CursorIndex);
                    CursorIndex += 4;
                    break;
                case ValueType.EightByteNonIndexedArray:
                    byteLength = BitConverter.ToInt64(data, CursorIndex);
                    CursorIndex += 8;
                    break;
                default:
                    // TODO: throw custom exception
                    throw new Exception("Can't parse array byte length.");
            }

            // cycle through array items until all of them are parsed
            // number of items in non indexed arrays is not known therefore array needs to be parsed until it's content length is reached
            while (byteLength != (CursorIndex - StartIndex))
            {
                // parse array item into segment
                var subSegment = VelocyPack.ToSegment(data, CursorIndex);

                // array segment cursor index needs to be shifted to recently parse sub segment cursor index
                CursorIndex = subSegment.CursorIndex;
                SubSegments.Add(subSegment);
            }
        }
    }
}