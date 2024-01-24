using Arango.VelocyPack.Net.Segments;
using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Segmentation
{
    [TestFixture]
    public class NullValueSegmentationTests
    {
        [Test]
        public void SegmentizeNullValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNullValue);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<NullSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.Null, segment.Type);
            Assert.Equals(ValueType.Null, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }
    }
}
