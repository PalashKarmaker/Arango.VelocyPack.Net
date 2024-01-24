using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Deserialization.Numbers
{
    [TestFixture]
    public class FloatValueDeserializationTests
    {
        [Test]
        public void DeserializePosOneByteFloatValue()
        {
            // given
            var data = Hex.PosOneByteLengthFloatValue;

            // when
            var value = VPack.ToObject<float>(data);

            // then
            Assert.Equals((float)12345, value);
        }

        [Test]
        public void DeserializeNegOneByteFloatValue()
        {
            // given
            var data = Hex.NegOneByteLengthFloatValue;

            // when
            var value = VPack.ToObject<float>(data);

            // then
            Assert.Equals((float)-12345, value);
        }
    }
}
