#define Debug

using System.Diagnostics;

namespace ConditionalAttributeTest;

internal class Program
{
    static void Main()
    {

#if Debug
        Console.WriteLine("Debug mode is active");
#endif

        int number = 0;
        for (int i = 0; i < 10; i++)
        {
            number += 2;
            DebugNumber(number);
        }

        [Conditional("Debug")]
        static void DebugNumber(int num)
        {
            Console.WriteLine($"number = {num}");
        }
    }
}
