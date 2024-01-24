using Arango.VelocyPack.Net.Segments;
using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Segmentation
{
    [TestFixture]
    public class NoneValueSegmentationTests
    {
        [Test]
        public void SegmentizeNoneValue()
        {
            // given
            var data = Hex.NoneValue;

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<NoneSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.None, segment.Type);
            Assert.Equals(ValueType.None, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }
    }
}
