using System;

namespace EnumerableEnumeratorClass
{
    record Person(string Name, int Age);

    class Program
    {
        static void Main()
        {
            Employees employees = new();

            Console.WriteLine("Staff list (foreach)");
            foreach (var item in employees)
            {
                Console.WriteLine("{0}".PadLeft(10), item.ToString());
            }

            Console.WriteLine();

            Console.WriteLine("Staff list (for)");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine("{0}".PadLeft(10), employees[i]);
            }
        }
    }
}
