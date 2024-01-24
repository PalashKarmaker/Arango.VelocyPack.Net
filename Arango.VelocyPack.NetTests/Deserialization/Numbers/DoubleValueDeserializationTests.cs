using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Deserialization.Numbers
{
    [TestFixture]
    public class DoubleValueDeserializationTests
    {
        [Test]
        public void DeserializeDoubleValue()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonDouble);

            // when
            var value = VPack.ToObject<double>(data);

            // then
            Assert.Equals(0.33333333333333331, value);
        }
    }
}
