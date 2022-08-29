using static System.Console;

WriteLine("--------------------------------------------------------------------------");
WriteLine("Type    Byte(s) of memory               Min                            Max");
WriteLine("--------------------------------------------------------------------------");
WriteLine($"sbyte   {default(sbyte)} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
WriteLine($"byte    {sizeof(byte)} {byte.MinValue,30} {byte.MaxValue,30}");
WriteLine($"short   {sizeof(short)} {short.MinValue,30} {short.MaxValue,30}");
WriteLine($"ushort  {sizeof(ushort)} {ushort.MinValue,30} {ushort.MaxValue,30}");
WriteLine($"int     {sizeof(int)} {int.MinValue,30} {int.MaxValue,30}");
WriteLine($"uint    {sizeof(uint)} {uint.MinValue,30} {uint.MaxValue,30}");
WriteLine($"long    {sizeof(long)} {long.MinValue,30} {long.MaxValue,30}");
WriteLine($"ulong   {sizeof(ulong)} {ulong.MinValue,30} {ulong.MaxValue,30}");
WriteLine($"float   {sizeof(float)} {float.MinValue,30} {float.MaxValue,30}");
WriteLine($"double  {sizeof(double)} {double.MinValue,30} {double.MaxValue,30}");
WriteLine($"decimal {sizeof(decimal)} {decimal.MinValue,30} {decimal.MaxValue,30}");
WriteLine("--------------------------------------------------------------------------");