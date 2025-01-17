﻿using Arango.VelocyPack.Net.Converters;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using ArrayConverter = Arango.VelocyPack.Net.Converters.ArrayConverter;

namespace Arango.VelocyPack.NetTests.Conversion
{
    [TestFixture]
    public class NumberConverterTests
    {
        #region Signed integers

        [Test]
        public void ConvertPositiveThreeByteSignedIntDataToInteger()
        {
            // given
            const int expectedValue = 123456;
            // binary representation of expected value
            var data = new byte[] { 64, 226, 1 };

            // when
            var value = NumberConverter.ToInteger(data);

            // then
            CollectionAssert.Equals(BitConverter.GetBytes(expectedValue), ArrayConverter.Append(data, 0));
            //TODO: Assert.IsInstanceOf<int>(value);
            Assert.Equals(expectedValue, value);
        }

        [Test]
        public void ConvertNegativeThreeByteSignedIntDataToInteger()
        {
            // given
            const int expectedValue = -123456;
            // binary representation of expected value
            var data = new byte[] { 192, 29, 254 };

            // when
            var value = NumberConverter.ToInteger(data);

            // then
            CollectionAssert.Equals(BitConverter.GetBytes(expectedValue), ArrayConverter.Append(data, 255));
            //TODO: Assert.IsInstanceOf<int>(value);
            Assert.Equals(expectedValue, value);
        }

        [Test]
        public void ConvertPositiveFiveByteSignedIntDataToInteger()
        {
            // given
            const long expectedValue = 12345678901;
            // binary representation of expected value
            var data = new byte[] { 53, 28, 220, 223, 2 };

            // when
            var value = NumberConverter.ToInteger(data);

            // then
            Equals(BitConverter.GetBytes(expectedValue), ArrayConverter.Join(data, [0, 0, 0]));
            //TODO: Assert.IsInstanceOf<long>(value);
            Assert.Equals(expectedValue, value);
        }

        [Test]
        public void ConvertNegativeFiveByteSignedIntDataToInteger()
        {
            // given
            const long expectedValue = -12345678901;
            // binary representation of expected value
            var data = new byte[] { 203, 227, 35, 32, 253 };

            // when
            var value = NumberConverter.ToInteger(data);

            // then
            CollectionAssert.Equals(BitConverter.GetBytes(expectedValue), ArrayConverter.Join(data, [255, 255, 255]));
            //TODO: Assert.IsInstanceOf<long>(value);
            Assert.Equals(expectedValue, value);
        }

        [Test]
        public void ConvertPositiveSixByteSignedIntDataToInteger()
        {
            // given
            const long expectedValue = 1234567890123;
            // binary representation of expected value
            var data = new byte[] { 203, 4, 251, 113, 31, 1 };

            // when
            var value = NumberConverter.ToInteger(data);

            // then
            CollectionAssert.Equals(BitConverter.GetBytes(expectedValue), ArrayConverter.Join(data, [0, 0]));
            //TODO: Assert.IsInstanceOf<long>(value);
            Assert.Equals(expectedValue, value);
        }

        [Test]
        public void ConvertNegativeSixByteSignedIntDataToInteger()
        {
            // given
            const long expectedValue = -1234567890123;
            // binary representation of expected value
            var data = new byte[] { 53, 251, 4, 142, 224, 254 };

            // when
            var value = NumberConverter.ToInteger(data);

            // then
            CollectionAssert.Equals(BitConverter.GetBytes(expectedValue), ArrayConverter.Join(data, [255, 255]));
            //TODO: Assert.IsInstanceOf<long>(value);
            Assert.Equals(expectedValue, value);
        }

        [Test]
        public void ConvertPositiveSevenByteSignedIntDataToInteger()
        {
            // given
            const long expectedValue = 1234567890123456;
            // binary representation of expected value
            var data = new byte[] { 192, 186, 138, 60, 213, 98, 4 };

            // when
            var value = NumberConverter.ToInteger(data);

            // then
            CollectionAssert.Equals(BitConverter.GetBytes(expectedValue), ArrayConverter.Append(data, 0));
            //TODO: Assert.IsInstanceOf<long>(value);
            Assert.Equals(expectedValue, value);
        }

        [Test]
        public void ConvertNegativeSevenByteSignedIntDataToInteger()
        {
            // given
            const long expectedValue = -1234567890123456;
            // binary representation of expected value
            var data = new byte[] { 64, 69, 117, 195, 42, 157, 251 };

            // when
            var value = NumberConverter.ToInteger(data);

            // then
            CollectionAssert.Equals(BitConverter.GetBytes(expectedValue), ArrayConverter.Append(data, 255));
            //TODO: Assert.IsInstanceOf<long>(value);
            Assert.Equals(expectedValue, value);
        }

        #endregion

        #region Unsigned integers

        [Test]
        public void ConvertOneByteUnsignedIntDataToInteger()
        {
            // given
            const byte expectedValue = 255;
            // binary representation of expected value
            var data = new byte[] { 255 };

            // when
            var value = NumberConverter.ToInteger(data, true);

            // then
            //TODO: Assert.IsInstanceOf<byte>(value);
            Assert.Equals(expectedValue, value);
        }

        [Test]
        public void ConvertTwoByteUnsignedIntDataToInteger()
        {
            // given
            const ushort expectedValue = 65535;
            // binary representation of expected value
            var data = new byte[] { 255, 255 };

            // when
            var value = NumberConverter.ToInteger(data, true);

            // then
            //TODO: Assert.IsInstanceOf<ushort>(value);
            Assert.Equals(expectedValue, value);
        }

        [Test]
        public void ConvertThreeByteUnsignedIntDataToInteger()
        {
            // given
            const uint expectedValue = 16777215;
            // binary representation of expected value
            var data = new byte[] { 255, 255, 255 };

            // when
            var value = NumberConverter.ToInteger(data, true);

            // then
            CollectionAssert.Equals(BitConverter.GetBytes(expectedValue), ArrayConverter.Append(data, 0));
            //TODO: Assert.IsInstanceOf<uint>(value);
            Assert.Equals(expectedValue, value);
        }

        [Test]
        public void ConvertFourByteUnsignedIntDataToInteger()
        {
            // given
            const uint expectedValue = 4294967295;
            // binary representation of expected value
            var data = new byte[] { 255, 255, 255, 255 };

            // when
            var value = NumberConverter.ToInteger(data, true);

            // then
            CollectionAssert.Equals(BitConverter.GetBytes(expectedValue), data);
            //TODO: Assert.IsInstanceOf<uint>(value);
            Assert.Equals(expectedValue, value);
        }

        [Test]
        public void ConvertFiveByteUnsignedIntDataToInteger()
        {
            // given
            const ulong expectedValue = 1099511627775;
            // binary representation of expected value
            var data = new byte[] { 255, 255, 255, 255, 255 };

            // when
            var value = NumberConverter.ToInteger(data, true);

            // then
            CollectionAssert.Equals(BitConverter.GetBytes(expectedValue), ArrayConverter.Join(data, [0, 0, 0]));
            //TODO: Assert.IsInstanceOf<ulong>(value);
            Assert.Equals(expectedValue, value);
        }

        [Test]
        public void ConvertSixByteUnsignedIntDataToInteger()
        {
            // given
            const ulong expectedValue = 281474976710655;
            // binary representation of expected value
            var data = new byte[] { 255, 255, 255, 255, 255, 255 };

            // when
            var value = NumberConverter.ToInteger(data, true);

            // then
            CollectionAssert.Equals(BitConverter.GetBytes(expectedValue), ArrayConverter.Join(data, [0, 0]));
            //TODO: Assert.IsInstanceOf<ulong>(value);
            Assert.Equals(expectedValue, value);
        }

        [Test]
        public void ConvertSevenByteUnsignedIntDataToInteger()
        {
            // given
            const ulong expectedValue = 72057594037927935;
            // binary representation of expected value
            var data = new byte[] { 255, 255, 255, 255, 255, 255, 255 };

            // when
            var value = NumberConverter.ToInteger(data, true);

            // then
            CollectionAssert.Equals(BitConverter.GetBytes(expectedValue), ArrayConverter.Append(data, 0));
            //TODO: Assert.IsInstanceOf<ulong>(value);
            Assert.Equals(expectedValue, value);
        }

        [Test]
        public void ConvertEightByteUnsignedIntDataToInteger()
        {
            // given
            const ulong expectedValue = 18446744073709551615;
            // binary representation of expected value
            var data = BitConverter.GetBytes(expectedValue);

            // when
            var value = NumberConverter.ToInteger(data, true);

            // then
            Assert.Equals(8, data.Length);
            //TODO: Assert.IsInstanceOf<ulong>(value);
            Assert.Equals(expectedValue, value);
        }

        #endregion
    }
}
