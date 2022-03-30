using System;

namespace EnumerableEnumeratorClass
{
    record Person(string Name, int Age);

    class Program
    {
        static void Main()
        {
            Employees employees = new();

            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
