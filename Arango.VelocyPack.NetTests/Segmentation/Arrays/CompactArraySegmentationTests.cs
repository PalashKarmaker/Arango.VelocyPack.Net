﻿using Arango.VelocyPack.Net.Segments;
using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Segmentation.Arrays
{
    [TestFixture]
    public class CompactArraySegmentationTests
    {
        [Test]
        public void SegmentizeCompactArray()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonCompactArray, true, false);

            // when
            var segment = VPack.ToSegment<CompactArraySegment>(data);

            // then
            // array
            //TODO: Assert.IsInstanceOf<CompactArraySegment>(segment);
            //TODO: Assert.IsInstanceOf<ArraySegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(6, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.CompactArray, segment.Type);
            Assert.Equals(ValueType.CompactNonIndexedArray, segment.ValueType);
            Assert.Equals(2, segment.ValueStartIndex);
            Assert.Equals(3, segment.ValueByteLength);
            Assert.Equals(3, segment.Items.Count);
            Assert.Equals(segment.ItemCount, segment.Items.Count);

            // first small integer segment item
            var item1 = segment.Items[0];

            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(item1);
            Assert.Equals(2, item1.StartIndex);
            Assert.Equals(3, item1.CursorIndex);
            Assert.Equals(SegmentType.SmallInteger, item1.Type);
            Assert.Equals(ValueType.PosOneInt, item1.ValueType);
            Assert.Equals(2, item1.ValueStartIndex);
            Assert.Equals(1, item1.ValueByteLength);

            // second small integer segment item
            var item2 = segment.Items[1];

            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(item2);
            Assert.Equals(3, item2.StartIndex);
            Assert.Equals(4, item2.CursorIndex);
            Assert.Equals(SegmentType.SmallInteger, item2.Type);
            Assert.Equals(ValueType.PosTwoInt, item2.ValueType);
            Assert.Equals(3, item2.ValueStartIndex);
            Assert.Equals(1, item2.ValueByteLength);

            // third small integer segment item
            var item3 = segment.Items[2];

            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(item3);
            Assert.Equals(4, item3.StartIndex);
            Assert.Equals(5, item3.CursorIndex);
            Assert.Equals(SegmentType.SmallInteger, item3.Type);
            Assert.Equals(ValueType.PosThreeInt, item3.ValueType);
            Assert.Equals(4, item3.ValueStartIndex);
            Assert.Equals(1, item3.ValueByteLength);
        }
    }
}