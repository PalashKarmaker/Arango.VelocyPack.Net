using System.Collections;

namespace Arango.VelocyPack.Net.Converters
{
    public static class BinaryConverter
    {
        public static bool IsBitSet(byte value, int position)
        {
            return (value & (1 << position)) != 0;
        }

        public static List<bool> ToBits(byte value)
        {
            var bits = new List<bool>();

            for (var i = 0; i < 8; i++)
            {
                bits.Add(IsBitSet(value, i));
            }

            return bits;
        }

        public static byte[] ToBytes(List<bool> bits)
        {
            var bitArray = new BitArray(bits.ToArray());
            var byteArray = new byte[(bitArray.Length - 1) / 8 + 1];

            bitArray.CopyTo(byteArray, 0);

            return byteArray;
        }
    }
}
