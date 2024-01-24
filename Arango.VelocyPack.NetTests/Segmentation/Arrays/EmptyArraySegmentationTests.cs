using Arango.VelocyPack.Net.Segments;
using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Segmentation.Arrays
{
    [TestFixture]
    public class EmptyArraySegmentationTests
    {
        [Test]
        public void SegmentizeEmptyArray()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonEmptyArray);

            // when
            var segment = VPack.ToSegment<EmptyArraySegment>(data);

            // then
            //TODO: Assert.IsInstanceOf<EmptyArraySegment>(segment);
            //TODO: Assert.IsInstanceOf<ArraySegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.EmptyArray, segment.Type);
            Assert.Equals(ValueType.EmptyArray, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
            Assert.Equals(0, segment.Items.Count);
        }
    }
}
