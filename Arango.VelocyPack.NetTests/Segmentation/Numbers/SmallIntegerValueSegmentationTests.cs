using Arango.VelocyPack.Net.Segments;
using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Segmentation.Numbers
{
    [TestFixture]
    public class SmallIntegerValueSegmentationTests
    {
        [Test]
        public void SegmentizeZeroIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonZeroInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SmallInteger, segment.Type);
            Assert.Equals(ValueType.ZeroInt, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosOneIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosOneInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SmallInteger, segment.Type);
            Assert.Equals(ValueType.PosOneInt, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosTwoIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosTwoInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SmallInteger, segment.Type);
            Assert.Equals(ValueType.PosTwoInt, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosThreeIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosThreeInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SmallInteger, segment.Type);
            Assert.Equals(ValueType.PosThreeInt, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosFourIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosFourInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SmallInteger, segment.Type);
            Assert.Equals(ValueType.PosFourInt, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosFiveIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosFiveInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SmallInteger, segment.Type);
            Assert.Equals(ValueType.PosFiveInt, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosSixIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosSixInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SmallInteger, segment.Type);
            Assert.Equals(ValueType.PosSixInt, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosSevenIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosSevenInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SmallInteger, segment.Type);
            Assert.Equals(ValueType.PosSevenInt, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosEightIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosEightInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SmallInteger, segment.Type);
            Assert.Equals(ValueType.PosEightInt, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizePosNineIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosNineInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SmallInteger, segment.Type);
            Assert.Equals(ValueType.PosNineInt, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeNegSixIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegSixInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SmallInteger, segment.Type);
            Assert.Equals(ValueType.NegSixInt, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeNegFiveIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegFiveInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SmallInteger, segment.Type);
            Assert.Equals(ValueType.NegFiveInt, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeNegFourIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegFourInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SmallInteger, segment.Type);
            Assert.Equals(ValueType.NegFourInt, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeNegThreeIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegThreeInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SmallInteger, segment.Type);
            Assert.Equals(ValueType.NegThreeInt, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeNegTwoIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegTwoInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SmallInteger, segment.Type);
            Assert.Equals(ValueType.NegTwoInt, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeNegOneIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegOneInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            //TODO: Assert.IsInstanceOf<SmallIntegerSegment>(segment);
            Assert.Equals(0, segment.StartIndex);
            Assert.Equals(1, segment.CursorIndex);
            Assert.Equals(data.Length, segment.ByteLength);
            Assert.Equals(SegmentType.SmallInteger, segment.Type);
            Assert.Equals(ValueType.NegOneInt, segment.ValueType);
            Assert.Equals(0, segment.ValueStartIndex);
            Assert.Equals(1, segment.ValueByteLength);
        }
    }
}
