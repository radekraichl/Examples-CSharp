using System;
using System.Collections;

namespace EnumerableMethod
{
    class Program
    {
        static void Main()
        {
            foreach (var item in GetNumbers())
            {
                if (item is int num)
                {
                    Console.WriteLine($"{num} (int)");
                }
                else
                {
                    Console.WriteLine($"{item} (object)");
                }
            }
        }

        static IEnumerable GetNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }

            yield return "END";
        }
    }
}
