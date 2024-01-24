using Arango.VelocyPack.Net.Segments;
using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Segmentation.Numbers
{
    [TestFixture]
    public class SignedIntegerValueSegmentationTests
    {
        [Test]
        public void SegmentizeOneByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonOneByteSignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SignedIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(2, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SignedInteger, segment.Type);
            Assert.Equals(ValueType.OneByteInt, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeTwoByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonTwoByteSignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SignedIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(3, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SignedInteger, segment.Type);
            Assert.Equals(ValueType.TwoByteInt, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(2, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeThreeByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonThreeByteSignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SignedIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(4, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SignedInteger, segment.Type);
            Assert.Equals(ValueType.ThreeByteInt, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(3, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeFourByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFourByteSignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SignedIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(5, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SignedInteger, segment.Type);
            Assert.Equals(ValueType.FourByteInt, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(4, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeFiveByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFiveByteSignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SignedIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(6, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SignedInteger, segment.Type);
            Assert.Equals(ValueType.FiveByteInt, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(5, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeSixByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonSixByteSignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SignedIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(7, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SignedInteger, segment.Type);
            Assert.Equals(ValueType.SixByteInt, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(6, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeSevenByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonSevenByteSignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SignedIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(8, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SignedInteger, segment.Type);
            Assert.Equals(ValueType.SevenByteInt, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(7, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeEightByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonEightByteSignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SignedIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(9, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SignedInteger, segment.Type);
            Assert.Equals(ValueType.EightByteInt, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(8, segment.ValueByteLength);
        }
    }
}
