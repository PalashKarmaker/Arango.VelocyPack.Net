using Arango.VelocyPack.Net.Segments;
using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Segmentation.Numbers
{
    [TestFixture]
    public class DoubleValueSegmentationTests
    {
        [Test]
        public void SegmentizeDoubleValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonDouble);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<DoubleSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(9, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.Double, segment.Type);
            Assert.Equals(ValueType.Double, segment.ValueType);
            Assert.Equals(1, segment.ValueStartIndex);
            Assert.Equals(8, segment.ValueByteLength);
        }
    }
}
