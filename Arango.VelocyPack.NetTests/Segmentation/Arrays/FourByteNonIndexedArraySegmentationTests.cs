using Arango.VelocyPack.Net.Segments;
using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Segmentation.Arrays
{
    [TestFixture]
    public class FourByteNonIndexedArraySegmentationTests
    {
        [Test]
        public void SegmentizeNonIndexedArray_With_ZeroZeroByteByteLengthSize()
        {
            // given
            var data = Hex.FourByteNonIndexedArrayWithZeroZeroBytes;

            // when
            var segment = VPack.ToSegment<NonIndexedArraySegment>(data);

            // then
            // array
            //TODO: Assert.IsInstanceOf<NonIndexedArraySegment>(segment);
            //TODO: Assert.IsInstanceOf<ArraySegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(data.Length, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.NonIndexedArray, segment.Type);
            Assert.Equals(ValueType.FourByteNonIndexedArray, segment.ValueType);
            Assert.Equals(5, segment.ValueStartIndex);
            Assert.Equals(3, segment.ValueByteLength);
            Assert.Equals(3, segment.Items.Count);

            TestSmallIntegerItems(segment);
        }

        [Test]
        public void SegmentizeNonIndexedArray_With_FourZeroByteByteLengthSize()
        {
            // given
            var data = Hex.FourByteNonIndexedArrayWithFourZeroBytes;

            // when
            var segment = VPack.ToSegment<NonIndexedArraySegment>(data);

            // then
            // array
            //TODO: Assert.IsInstanceOf<NonIndexedArraySegment>(segment);
            //TODO: Assert.IsInstanceOf<ArraySegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(data.Length, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.NonIndexedArray, segment.Type);
            Assert.Equals(ValueType.FourByteNonIndexedArray, segment.ValueType);
            Assert.Equals(9, segment.ValueStartIndex);
            Assert.Equals(3, segment.ValueByteLength);
            Assert.Equals(3, segment.Items.Count);

            TestSmallIntegerItems(segment);
        }

        private void TestSmallIntegerItems(NonIndexedArraySegment segment)
        {
            // first item
            var item1 = segment.Items[0];

            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(item1);
            Assert.Equals(SegmentType.SmallInteger, item1.Type);
            Assert.Equals(ValueType.PosOneInt, item1.ValueType);

            // second item
            var item2 = segment.Items[1];

            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(item2);
            Assert.Equals(SegmentType.SmallInteger, item2.Type);
            Assert.Equals(ValueType.PosTwoInt, item2.ValueType);

            // third item
            var item3 = segment.Items[2];

            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(item3);
            Assert.Equals(SegmentType.SmallInteger, item3.Type);
            Assert.Equals(ValueType.PosThreeInt, item3.ValueType);
        }
    }
}
