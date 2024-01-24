using Arango.VelocyPack.Net.Segments;
using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Segmentation.Numbers
{
    [TestFixture]
    public class FloatValueSegmentationTests
    {
        [Test]
        public void SegmentizePosOneByteFloatValue()
        {
            // given
            var data = Hex.PosOneByteLengthFloatValue;

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<FloatSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(9, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.Float, segment.Type);
            Assert.Equals(ValueType.PosOneByteFloat, segment.ValueType);
            Assert.Equals(6, segment.ValueStartIndex);
            Assert.Equals(3, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeNegOneByteFloatValue()
        {
            // given
            var data = Hex.NegOneByteLengthFloatValue;

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<FloatSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(9, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.Float, segment.Type);
            Assert.Equals(ValueType.NegOneByteFloat, segment.ValueType);
            Assert.Equals(6, segment.ValueStartIndex);
            Assert.Equals(3, segment.ValueByteLength);
        }
    }
}
