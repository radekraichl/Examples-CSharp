using System;
using System.Collections.Generic;

namespace EnumerableGenericMethod
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("NAMES:");
            
            foreach (var item in GetNames())
            {
                Console.WriteLine("{0}".PadLeft(10), item);
            }
        }

        static IEnumerable<string> GetNames()
        {
            string[] names = { "Radek", "Franta", "Karel" };

            foreach (var item in names)
            {
                yield return item;
            }
        }
    }
}
