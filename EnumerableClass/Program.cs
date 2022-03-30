using System;
using System.Collections;

namespace EnumerableClass
{
    class Program
    {
        static void Main()
        {
            Cars cars = new();

            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }

            IEnumerator data = new Cars().GetEnumerator();

            while (data.MoveNext())
            {
                Console.WriteLine($"Auto : {data.Current}");
            }
        }
    }
}
