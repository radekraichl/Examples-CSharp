using System;
using System.Collections;

namespace EnumerableClass
{
    class Program
    {
        static void Main()
        {
            CarList cars = new();

            Console.WriteLine("foreach (var car in cars)");
            foreach (var car in cars)
            {
                Console.WriteLine("{0}".PadLeft(8), car);
            }

            Console.WriteLine();

            Console.WriteLine("while (data.MoveNext())");
            IEnumerator data = new CarList().GetEnumerator();
            while (data.MoveNext())
            {
                Console.WriteLine("{0}".PadLeft(8), data.Current);
            }
        }
    }
}
