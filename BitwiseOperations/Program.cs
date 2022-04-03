int value = int.MaxValue;

Console.WriteLine("{0, 20:N0} - {1}", value, Convert.ToString(value, 2).PadLeft(32, '0'));

// negace
value = ~value;
Console.WriteLine("{0, 20:N0} - {1}", value, Convert.ToString(value, 2).PadLeft(32, '0'));
Console.WriteLine();

// posun >>=
int cislo = -512;
for (int i = 0; i < 11; i++)
{
    Console.WriteLine("{0, 20:N0} - {1}", cislo, Convert.ToString(cislo, 2).PadLeft(32, '0'));
    cislo >>= 1;
}

Console.WriteLine();

// posun <<=
cislo = 1;
for (int i = 0; i < 34; i++)
{
    Console.WriteLine("{0, 20:N0} - {1}", cislo, Convert.ToString(cislo, 2).PadLeft(32, '0'));
    cislo <<= 1;
}
