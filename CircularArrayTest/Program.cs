using System;

namespace CircularArrayTest
{
    class Program
    {
        static void Main()
        {
            var myCircuralList = new CircularArray<int>(3);
            myCircuralList[0] = 1;
            myCircuralList[1] = 2;
            myCircuralList[2] = 3;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(myCircuralList.Value);
                myCircuralList.Next();
            }
        }
    }
}