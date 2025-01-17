﻿using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Deserialization.Numbers
{
    [TestFixture]
    public class SmallIntegerValueDeserializationTests
    {
        [Test]
        public void DeserializeZeroIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonZeroInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals(0, value);
        }

        [Test]
        public void DeserializePosOneIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosOneInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals(1, value);
        }

        [Test]
        public void DeserializePosTwoIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosTwoInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals(2, value);
        }

        [Test]
        public void DeserializePosThreeIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosThreeInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals(3, value);
        }

        [Test]
        public void DeserializePosFourIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosFourInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals(4, value);
        }

        [Test]
        public void DeserializePosFiveIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosFiveInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals(5, value);
        }

        [Test]
        public void DeserializePosSixIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosSixInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals(6, value);
        }

        [Test]
        public void DeserializePosSevenIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosSevenInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals(7, value);
        }

        [Test]
        public void DeserializePosEightIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosEightInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals(8, value);
        }

        [Test]
        public void DeserializePosNineIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonPosNineInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals(9, value);
        }

        [Test]
        public void DeserializeNegSixIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegSixInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals(-6, value);
        }

        [Test]
        public void DeserializeNegFiveIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegFiveInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals(-5, value);
        }

        [Test]
        public void DeserializeNegFourIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegFourInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals(-4, value);
        }

        [Test]
        public void DeserializeNegThreeIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegThreeInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals(-3, value);
        }

        [Test]
        public void DeserializeNegTwoIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegTwoInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals(-2, value);
        }

        [Test]
        public void DeserializeNegOneIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNegOneInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals(-1, value);
        }
    }
}
