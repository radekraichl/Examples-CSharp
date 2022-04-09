byte variable = default;

for (int i = 0; i < byte.MaxValue + 1; i++)
{
    checked
    {
        try
        {
            variable++;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

    if (variable == 0)
    {
        Console.WriteLine("Overflow !");
    }
}

Console.WriteLine(variable);
