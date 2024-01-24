using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Deserialization.Arrays
{
    [TestFixture]
    public class EightByteNonIndexedArrayDeserializationTests
    {
        [Test]
        public void DeserializeNonIndexedArray()
        {
            // given
            var data = Hex.EightByteNonIndexedArray;

            // when
            var value = VPack.ToObject<List<object>>(data);

            // then
            // array
            //TODO: Assert.IsInstanceOf<List<object>>(value);
            Assert.Equals(3, value.Count);

            // first item
            var item1 = value[0];

            //TODO: Assert.IsInstanceOf<sbyte>(item1);
            Assert.Equals(1, item1);

            // second item
            var item2 = value[1];

            //TODO: Assert.IsInstanceOf<sbyte>(item2);
            Assert.Equals(2, item2);

            // third item
            var item3 = value[2];

            //TODO: Assert.IsInstanceOf<sbyte>(item3);
            Assert.Equals(3, item3);
        }
    }
}
