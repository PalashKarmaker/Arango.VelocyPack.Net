﻿using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.SegmentParsing
{
    [TestFixture]
    public class IllegalValueTests
    {
        [Test]
        public void ParseIllegalValue()
        {
            // given
            // hex dump of illegal value
            var data = new byte[] { 0x17 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<IllegalSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.Illegal, segment.Type);
            Assert.AreEqual(ValueType.Illegal, segment.ValueType);
        }
    }
}
