using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Deserialization
{
    [TestFixture]
    public class NullValueDeserializationTests
    {
        [Test]
        public void DeserializeNullValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonNullValue);

            // when
            var value = VPack.ToObject<object>(data);

            // then
            Assert.That(value, Is.Null);
        }
    }
}
