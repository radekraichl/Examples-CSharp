Cisla cisla = Cisla.ONE | Cisla.TWO | Cisla.FOUR;

Console.WriteLine(cisla);
Console.WriteLine(cisla.HasFlag(Cisla.NONE));

CislaSNulou cislaSNulou = new();
cislaSNulou |= CislaSNulou.ONE;
cislaSNulou ^= CislaSNulou.ONE;

Console.WriteLine(cislaSNulou);
Console.WriteLine($"NONE: {cislaSNulou.Equals(CislaSNulou.NONE)}");     // dotaz na NONE
Console.WriteLine(cislaSNulou.HasFlag(CislaSNulou.TWO));
Console.WriteLine((cislaSNulou & CislaSNulou.ONE) == CislaSNulou.ONE);

[Flags]
enum Cisla
{
    NONE = 1,
    ONE = 2,
    TWO = 4,
    THREE = 8,
    FOUR = 16,
};

[Flags]
enum CislaSNulou
{
    NONE = 0,
    ONE = 1,
    TWO = 2,
    THREE = 4,
    FOUR = 8,
};
