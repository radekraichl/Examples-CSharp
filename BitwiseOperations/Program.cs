int value = int.MaxValue;

Console.WriteLine("int.MaxValue");
Console.WriteLine("{0, 20:N0} - {1}", value, Convert.ToString(value, 2).PadLeft(32, '0'));

// negace
value = ~value;
Console.WriteLine("Negace");
Console.WriteLine("{0, 20:N0} - {1}", value, Convert.ToString(value, 2).PadLeft(32, '0'));
Console.WriteLine();

// posun vpravo >>=
Console.WriteLine("Posun vpravo >>=");
value = -16;

for (int i = 0; i < 6; i++)
{
    Console.WriteLine("{0, 20:N0} - {1}", value, Convert.ToString(value, 2).PadLeft(32, '0'));
    value >>= 1;
}

Console.WriteLine();

// posun vlevo <<=
Console.WriteLine("Posun vlevo <<=");
value = 268435456;

for (int i = 0; i < 6; i++)
{
    Console.WriteLine("{0, 20:N0} - {1}", value, Convert.ToString(value, 2).PadLeft(32, '0'));
    value <<= 1;
}
