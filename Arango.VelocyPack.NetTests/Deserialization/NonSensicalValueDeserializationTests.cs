using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Deserialization
{
    [TestFixture]
    public class NonSensicalValueDeserializationTests
    {
        [Test]
        public void DeserializeMinKeyValue()
        {
            // given
            var data = Hex.MinKeyValue;

            // when
            var value = VPack.ToObject<object>(data);

            // then
            Assert.That(value, Is.Null);
        }

        [Test]
        public void DeserializeMaxKeyValue()
        {
            // given
            var data = Hex.MaxKeyValue;

            // when
            var value = VPack.ToObject<object>(data);

            // then
            Assert.That(value, Is.Null);
        }
    }
}
