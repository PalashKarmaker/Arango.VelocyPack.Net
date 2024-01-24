using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Deserialization.Numbers
{
    [TestFixture]
    public class UnsignedIntegerValueDeserializationTests
    {
        [Test]
        public void DeserializeOneByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonOneByteUnsignedInt);

            // when
            var value = VPack.ToObject<byte>(data);

            // then
            Assert.Equals((byte)255, value);
        }

        [Test]
        public void DeserializeTwoByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonTwoByteUnsignedInt);

            // when
            var value = VPack.ToObject<ushort>(data);

            // then
            Assert.Equals((ushort)65535, value);
        }

        [Test]
        public void DeserializeThreeByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonThreeByteUnsignedInt);

            // when
            var value = VPack.ToObject<uint>(data);

            // then
            Assert.Equals((uint)16777215, value);
        }

        [Test]
        public void DeserializeFourByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFourByteUnsignedInt);

            // when
            var value = VPack.ToObject<uint>(data);

            // then
            Assert.Equals(4294967295, value);
        }

        [Test]
        public void DeserializeFiveByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFiveByteUnsignedInt);

            // when
            var value = VPack.ToObject<ulong>(data);

            // then
            Assert.Equals((ulong)1099511627775, value);
        }

        [Test]
        public void DeserializeSixByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonSixByteUnsignedInt);

            // when
            var value = VPack.ToObject<ulong>(data);

            // then
            Assert.Equals((ulong)281474976710655, value);
        }

        [Test]
        public void DeserializeSevenByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonSevenByteUnsignedInt);

            // when
            var value = VPack.ToObject<ulong>(data);

            // then
            Assert.Equals((ulong)72057594037927935, value);
        }

        [Test]
        public void DeserializeEightByteUnsignedIntValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonEightByteUnsignedInt);

            // when
            var value = VPack.ToObject<ulong>(data);

            // then
            Assert.Equals(18446744073709551615, value);
        }
    }
}
