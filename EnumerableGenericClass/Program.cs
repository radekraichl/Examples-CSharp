using System;
using System.Collections;
using System.Collections.Generic;

namespace EnumerableGenericClass
{
    class Program
    {
        static void Main()
        {
            var myCollection = new MyGenericCollection();

            foreach (var item in myCollection)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class MyGenericCollection : IEnumerable<int>
    {
        private readonly int[] data = { 1, 2, 3 };

        public IEnumerator<int> GetEnumerator()
        {
            foreach (int i in data)
            {
                yield return i;
            }
        }  

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
