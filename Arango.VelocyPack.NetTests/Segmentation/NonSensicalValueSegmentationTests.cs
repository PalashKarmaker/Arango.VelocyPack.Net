using Arango.VelocyPack.Net.Segments;
using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Segmentation
{
    [TestFixture]
    public class NonSensicalValueSegmentationTests
    {
        [Test]
        public void SegmentizeMinKeyValue()
        {
            // given
            var data = Hex.MinKeyValue;

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<NonSensicalSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.NonSensical, segment.Type);
            Assert.Equals(ValueType.MinKey, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeMaxKeyValue()
        {
            // given
            var data = Hex.MaxKeyValue;

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<NonSensicalSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.NonSensical, segment.Type);
            Assert.Equals(ValueType.MaxKey, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }
    }
}
