using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Deserialization.Arrays;

[TestFixture]
public class CompactArrayDeserializationTests
{
    [Test]
    public void DeserializeCompactArray()
    {
        // TODO: cast to List<sbyte>

        // given
        var data = Converter.ToVPackBytes(Paths.JsonCompactArray, true, false);

        // when
        var value = VPack.ToObject<List<object>>(data);

        // then
        // array
        Assert.That(value, Is.InstanceOf<List<object>>());
        Assert.Equals(3, value.Count);

        // first item
        var item1 = value[0];
        Assert.That(item1, Is.InstanceOf<byte>());
        Assert.Equals(1, item1);

        // second item
        var item2 = value[1];
        Assert.That(item2, Is.InstanceOf<sbyte>());
        Assert.Equals(2, item2);

        // third item
        var item3 = value[2];
        Assert.That(item3, Is.InstanceOf<sbyte>());
        Assert.Equals(3, item3);
    }
}
