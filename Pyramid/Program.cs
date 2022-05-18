int peak = 8;

for (int i = 1; i <= peak; i++)
{
    PrintLine(i);
}

for (int i = peak - 1; i >= 1; i--)
{
    PrintLine(i);
}

static void PrintLine(int number)
{
    for (int j = 1; j <= number; j++)
    {
        Console.Write($"{j} ");
    }

    Console.WriteLine();
}
