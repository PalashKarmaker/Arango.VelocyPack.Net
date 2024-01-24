using Arango.VelocyPack.Net.Segments;
using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Segmentation
{
    [TestFixture]
    public class BooleanValueSegmentationTests
    {
        [Test]
        public void SegmentizeFalseBooleanValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFalseValue);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<BooleanSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.Boolean, segment.Type);
            Assert.Equals(ValueType.False, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeTrueBooleanValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonTrueValue);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<BooleanSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.Boolean, segment.Type);
            Assert.Equals(ValueType.True, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }
    }
}
