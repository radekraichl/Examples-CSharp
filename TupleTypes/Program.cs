using System;

namespace TupleTypes
{
    class Program
    {
        static void Main()
        {
            (double, int) tuple1 = (4.5, 3);
            (double Sum, int Count) tuple2 = (4.5, 3);
            var tuple3 = (Sum: 4.5, Count: 3);
            var tuple4 = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26);

            Console.WriteLine($"Tuple with elements {tuple1.Item1} and {tuple1.Item2}.");
            Console.WriteLine($"Sum of {tuple2.Count} elements is {tuple2.Sum}.");
            Console.WriteLine($"Hash code of {tuple2} is {tuple2.GetHashCode()}.");
            Console.WriteLine($"t1 == t2 {tuple1 == tuple2}");
            Console.WriteLine(tuple3);
            Console.WriteLine(tuple4.Item26);

            Tuple<int, int> t = new(128, 128);
            Console.WriteLine(t);
            //t.Item1 = 5;  // error - readonly
        }
    }
}
