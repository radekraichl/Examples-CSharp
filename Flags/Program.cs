Cisla cisla = Cisla.ONE | Cisla.TWO | Cisla.THREE;

Console.WriteLine(cisla);
Console.WriteLine("cisla.HasFlag(Cisla.FOUR): " + cisla.HasFlag(Cisla.FOUR));

cisla |= Cisla.FOUR;
Console.WriteLine(cisla);
Console.WriteLine("cisla.HasFlag(Cisla.FOUR): " + cisla.HasFlag(Cisla.FOUR));

Console.WriteLine($"NONE: {cisla.Equals(Cisla.NONE)}");     // query for NONE
cisla = 0;
Console.WriteLine($"NONE: {cisla.Equals(Cisla.NONE)}");     // query for NONE

[Flags]
enum Cisla
{
    NONE = 0,
    ONE = 1,
    TWO = 2,
    THREE = 4,
    FOUR = 8,
    ALL = ONE | TWO | THREE | FOUR,
};
