using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Deserialization
{
    [TestFixture]
    public class BooleanValueDeserializationTests
    {
        [Test]
        public void DeserializeFalseBooleanValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonFalseValue);

            // when
            var value = VPack.ToObject<bool>(data);

            // then
            Assert.That(value, Is.False);
        }

        [Test]
        public void DeserializeTrueBooleanValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonTrueValue);

            // when
            var value = VPack.ToObject<bool>(data);

            // then
            Assert.That(value, Is.True);
        }
    }
}
