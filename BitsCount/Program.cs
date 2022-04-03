using System.Numerics;

int number = 1234;

Console.WriteLine("{0} - {1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));

Console.WriteLine("Počet nastavených bitů: {0} (metoda CountBits)", CountBits(number));
Console.WriteLine("Počet nastavených bitů: {0} (metoda BitOperations.PopCount)", BitOperations.PopCount((ulong)number));

static int CountBits(int value)
{
    value -= ((value >> 1) & 0x55555555);
    value = (value & 0x33333333) + ((value >> 2) & 0x33333333);
    return (((value + (value >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
}
