using System;
using System.Collections.Generic;

namespace EnumerableGenericMethod
{
    class Program
    {
        static void Main()
        {
            foreach (var item in GetNames())
            {
                Console.WriteLine(item);
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