namespace Arango.VelocyPack.Net.Converters;

public static class ArrayConverter
{
    public static byte[] Append(byte[] array, byte item)
    {
        return [.. array, .. new[] { item }];
    }

    public static byte[] Join(byte[] array1, byte[] array2)
    {
        return [.. array1, .. array2];
    }

    public static byte[] Slice(byte[] data, int index, int length)
    {
        var slicedArray = new byte[length];

        Array.Copy(data, index, slicedArray, 0, length);

        return slicedArray;
    }

    public static byte[] ReverseCopy(byte[] data)
    {
        var arrayReverseCopy = new byte[data.Length];

        for (var i = 0; i < data.Length; i++)
        {
            arrayReverseCopy[data.Length - 1 - i] = data[i];
        }

        return arrayReverseCopy;
    }
}
