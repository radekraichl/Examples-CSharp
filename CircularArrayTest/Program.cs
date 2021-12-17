using System;

namespace CircularArrayTest
{
    class Program
    {
        static void Main()
        {
            var myCircuralArr = new CircularArray<int>(3);
            myCircuralArr[0] = 1;
            myCircuralArr[1] = 2;
            myCircuralArr[2] = 3;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(myCircuralArr.Value);
                myCircuralArr.Next();
            }
        }
    }
}