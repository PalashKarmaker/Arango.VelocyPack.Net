using Arango.VelocyPack.Net.Segments;
using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Segmentation
{
    [TestFixture]
    public class IllegalValueSegmentationTests
    {
        [Test]
        public void SegmentizeIllegalValue()
        {
            // given
            var data = Hex.IllegalValue;

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<IllegalSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.Illegal, segment.Type);
            Assert.Equals(ValueType.Illegal, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }
    }
}
