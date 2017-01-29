﻿using NUnit.Framework;
using Arango.VelocyPack.Segments;
using Arango.VelocyPack.Tests.Utils;

namespace Arango.VelocyPack.Tests.Segmentation.Numbers
{
    [TestFixture]
    public class SignedIntegerValueTests
    {
        [Test]
        public void SegmentizeOneByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonOneByteSignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SignedIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(2, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SignedInteger, segment.Type);
            Assert.AreEqual(ValueType.OneByteInt, segment.ValueType);
            Assert.AreEqual(1, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeTwoByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonTwoByteSignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SignedIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(3, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SignedInteger, segment.Type);
            Assert.AreEqual(ValueType.TwoByteInt, segment.ValueType);
            Assert.AreEqual(1, segment.ValueStartIndex);
            Assert.AreEqual(2, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeThreeByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonThreeByteSignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SignedIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(4, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SignedInteger, segment.Type);
            Assert.AreEqual(ValueType.ThreeByteInt, segment.ValueType);
            Assert.AreEqual(1, segment.ValueStartIndex);
            Assert.AreEqual(3, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeFourByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFourByteSignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SignedIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(5, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SignedInteger, segment.Type);
            Assert.AreEqual(ValueType.FourByteInt, segment.ValueType);
            Assert.AreEqual(1, segment.ValueStartIndex);
            Assert.AreEqual(4, segment.ValueByteLength);
        }

        [Test]
        public void SegmentizeEightByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonEightByteSignedInt);

            // when
            var segment = VPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<SignedIntegerSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(9, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.SignedInteger, segment.Type);
            Assert.AreEqual(ValueType.EightByteInt, segment.ValueType);
            Assert.AreEqual(1, segment.ValueStartIndex);
            Assert.AreEqual(8, segment.ValueByteLength);
        }
    }
}
