using System;

namespace TupleTypes
{
    class Program
    {
        static void Main()
        {
            (double, int) t1 = (4.5, 3);
            Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");

            (double Sum, int Count) t2 = (4.5, 3);
            Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
            Console.WriteLine($"Hash code of {t2} is {t2.GetHashCode()}.");

            Console.WriteLine($"t1 == t2 {t1 == t2}");

            var t3 =
                (1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18,
                19, 20, 21, 22, 23, 24, 25, 26);
            Console.WriteLine(t3.Item26);

            var t4 = (Sum: 4.5, Count: 3);
            Console.WriteLine(t4);
        }
    }
}