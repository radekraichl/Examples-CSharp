using System;
using System.Collections;

namespace EnumeratorMethod
{
    class Program
    {
        static void Main()
        {
            IEnumerator data = GetNumbers();

            while (data.MoveNext())
            {
                Console.WriteLine(data.Current + " ");
            }
        }

        static IEnumerator GetNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }

            yield return "END";
        }
    }
}
