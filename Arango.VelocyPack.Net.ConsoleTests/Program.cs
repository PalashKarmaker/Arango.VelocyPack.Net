using Arango.VelocyPack.Net.Segments;
using Arango.VelocyPack.Net.Segments.Base;
HexDump();

//ParseArrayToSegment();


static void HexDump()
{
    sbyte sbyteInt = -10;
    short int16 = -10;
    int int32 = -10;
    long int64 = -10;

    Console.WriteLine("Little endian: {0}", BitConverter.IsLittleEndian);
    Console.WriteLine("sbyte hex: {0}", sbyteInt.ToString("X"));
    Console.WriteLine("int16 hex: {0}", int16.ToString("X"));
    Console.WriteLine("int32 hex: {0}", int32.ToString("X"));
    Console.WriteLine("int64 hex: {0}", int64.ToString("X"));
}

//static void ParseArrayToSegment()
//{
//    // hex dump of [1, 2, 3]
//    var arrayBytes = new byte[] { 0x02, 0x05, 0x31, 0x32, 0x33 };
//    // parsed segment
//    var arraySegment = VPack.ToSegment(arrayBytes);

//    PrintSegment(arraySegment);
//}

static void PrintSegment(Segment segment, int indentLevel = 0)
{
    for (int i = 0; i < indentLevel; i++)
    {
        Console.Write("    ");
    }

    Console.WriteLine("{0} {1}->{2}: {3}", segment.ValueType, segment.StartIndex, segment.CursorIndex, segment.Type);

    if ((segment is ArraySegment segment1) && (segment1.Items != null))
    {
        indentLevel++;

        foreach (var item in segment1.Items)
        {
            PrintSegment(item, indentLevel);
        }
    }
}