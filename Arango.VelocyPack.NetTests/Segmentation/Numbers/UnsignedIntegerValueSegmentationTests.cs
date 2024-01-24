using Arango.VelocyPack.Net.Segments;
using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Segmentation.Numbers
{
    [TestFixture]
    public class UnsignedIntegerValueSegmentationTests
    {
        [Test]
        public void SegmentizeOneByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonOneByteUnsignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<UnsignedIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(2, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.UnsignedInteger, segment.Type);
            Assert.Equals(ValueType.OneByteUInt, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeTwoByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonTwoByteUnsignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<UnsignedIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(3, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.UnsignedInteger, segment.Type);
            Assert.Equals(ValueType.TwoByteUInt, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(2, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeThreeByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonThreeByteUnsignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<UnsignedIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(4, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.UnsignedInteger, segment.Type);
            Assert.Equals(ValueType.ThreeByteUInt, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(3, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeFourByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFourByteUnsignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<UnsignedIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(5, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.UnsignedInteger, segment.Type);
            Assert.Equals(ValueType.FourByteUInt, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(4, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeFiveByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFiveByteUnsignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<UnsignedIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(6, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.UnsignedInteger, segment.Type);
            Assert.Equals(ValueType.FiveByteUInt, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(5, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeSixByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonSixByteUnsignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<UnsignedIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(7, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.UnsignedInteger, segment.Type);
            Assert.Equals(ValueType.SixByteUInt, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(6, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeSevenByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonSevenByteUnsignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<UnsignedIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(8, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.UnsignedInteger, segment.Type);
            Assert.Equals(ValueType.SevenByteUInt, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(7, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeEightByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonEightByteUnsignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<UnsignedIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(9, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.UnsignedInteger, segment.Type);
            Assert.Equals(ValueType.EightByteUInt, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(8, segment.ValueByteLength);
        }
    }
}
