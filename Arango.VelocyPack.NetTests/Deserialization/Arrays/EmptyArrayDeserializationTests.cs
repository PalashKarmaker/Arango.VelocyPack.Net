using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Deserialization.Arrays
{
    [TestFixture]
    public class EmptyArrayDeserializationTests
    {
        [Test]
        public void DeserializeEmptyArray()
        {
            // given
            var data = Converter.ToVPackBytes(Paths.JsonEmptyArray);

            // when
            var value = VPack.ToObject<List<object>>(data);

            // then
            //TODO: Assert.IsInstanceOf<List<object>>(value);
            Assert.Equals(0, value.Count);
        }
    }
}
