using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Deserialization
{
    [TestFixture]
    public class NoneValueDeserializationTests
    {
        [Test]
        public void DeserializeNoneValue()
        {
            // given
            var data = new byte[] { 0x00 };

            // when
            var value = VPack.ToObject<object>(data);

            // then
            Assert.That(value, Is.Null);
        }
    }
}
