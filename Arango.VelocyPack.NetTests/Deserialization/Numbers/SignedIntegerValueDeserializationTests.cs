using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Deserialization.Numbers
{
    [TestFixture]
    public class SignedIntegerValueDeserializationTests
    {
        [Test]
        public void DeserializeOneByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonOneByteSignedInt);

            // when
            var value = VPack.ToObject<sbyte>(data);

            // then
            Assert.Equals((sbyte)-12, value);
        }

        [Test]
        public void DeserializeTwoByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonTwoByteSignedInt);

            // when
            var value = VPack.ToObject<short>(data);

            // then
            Assert.Equals((short)-12345, value);
        }

        [Test]
        public void DeserializeThreeByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonThreeByteSignedInt);

            // when
            var value = VPack.ToObject<int>(data);

            // then
            Assert.Equals(-123456, value);
        }

        [Test]
        public void DeserializeFourByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFourByteSignedInt);

            // when
            var value = VPack.ToObject<int>(data);

            // then
            Assert.Equals(-123456789, value);
        }

        [Test]
        public void DeserializeFiveByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFiveByteSignedInt);

            // when
            var value = VPack.ToObject<long>(data);

            // then
            Assert.Equals(-12345678901, value);
        }

        [Test]
        public void DeserializeSixByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonSixByteSignedInt);

            // when
            var value = VPack.ToObject<long>(data);

            // then
            Assert.Equals(-1234567890123, value);
        }

        [Test]
        public void DeserializeSevenByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonSevenByteSignedInt);

            // when
            var value = VPack.ToObject<long>(data);

            // then
            Assert.Equals(-1234567890123456, value);
        }

        [Test]
        public void DeserializeEightByteSignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonEightByteSignedInt);

            // when
            var value = VPack.ToObject<long>(data);

            // then
            Assert.Equals(-1234567890123456789, value);
        }
    }
}
