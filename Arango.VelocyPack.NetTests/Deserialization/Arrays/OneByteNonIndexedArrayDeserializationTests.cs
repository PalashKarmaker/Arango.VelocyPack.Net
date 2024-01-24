﻿using Arango.VelocyPack.Net.Tests.Utils;
using NUnit.Framework;

namespace Arango.VelocyPack.Net.Tests.Deserialization.Arrays
{
    [TestFixture]
    public class OneByteNonIndexedArrayDeserializationTests
    {
        [Test]
        public void DeserializeNonIndexedArray_With_ZeroZeroByteByteLengthSize()
        {
            // given
            var data = Hex.OneByteNonIndexedArrayWithZeroZeroBytes;

            // when
            var value = VPack.ToObject<List<object>>(data);

            // then
            // array
            //TODO: Assert.IsInstanceOf<List<object>>(value);
            Assert.Equals(3, value.Count);

            TestSmallIntegerItems(value);
        }

        [Test]
        public void DeserializeNonIndexedArray_With_OneZeroByteByteLengthSize()
        {
            // given
            var data = Hex.OneByteNonIndexedArrayWithOneZeroBytes;

            // when
            var value = VPack.ToObject<List<object>>(data);

            // then
            // array
            //TODO: Assert.IsInstanceOf<List<object>>(value);
            Assert.Equals(3, value.Count);

            TestSmallIntegerItems(value);
        }

        [Test]
        public void DeserializeNonIndexedArray_With_ThreeZeroByteByteLengthSize()
        {
            // given
            var data = Hex.OneByteNonIndexedArrayWithThreeZeroBytes;

            // when
            var value = VPack.ToObject<List<object>>(data);

            // then
            // array
            //TODO: Assert.IsInstanceOf<List<object>>(value);
            Assert.Equals(3, value.Count);

            TestSmallIntegerItems(value);
        }

        [Test]
        public void DeserializeNonIndexedArray_With_SevenZeroByteByteLengthSize()
        {
            // given
            var data = Hex.OneByteNonIndexedArrayWithSevenZeroBytes;

            // when
            var value = VPack.ToObject<List<object>>(data);

            // then
            // array
            //TODO: Assert.IsInstanceOf<List<object>>(value);
            Assert.Equals(3, value.Count);

            TestSmallIntegerItems(value);
        }

        private void TestSmallIntegerItems(List<object> items)
        {
            // first item
            var item1 = items[0];

            //TODO: Assert.IsInstanceOf<sbyte>(item1);
            Assert.Equals(1, item1);

            // second item
            var item2 = items[1];

            //TODO: Assert.IsInstanceOf<sbyte>(item2);
            Assert.Equals(2, item2);

            // third item
            var item3 = items[2];

            //TODO: Assert.IsInstanceOf<sbyte>(item3);
            Assert.Equals(3, item3);
        }
    }
}
