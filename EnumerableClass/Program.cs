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

    /// <summary>
    /// Třída implementující IEnumerable která umožnuje procházení aut pomocí foreach
    /// </summary>
    class Cars : IEnumerable
    {
        private readonly string[] carlist =
        {
            "Ford",
            "Fiat",
            "Skoda",
            "Dacia",
            "Dodge",
            "Honda"
        };

        public IEnumerator GetEnumerator()
        {
            return new StringArrayEnum(carlist);
        }
    }

    /// <summary>
    /// Pomocná třída implemenujicí IEnumerator na procházení pole stringů
    /// </summary>
    class StringArrayEnum : IEnumerator
    {
        public string[] stringArray;

        int position = -1;

        public StringArrayEnum(string[] stringArr)
        {
            stringArray = stringArr;
        }

        public bool MoveNext()
        {
            position++;
            return (position < stringArray.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                try
                {
                    return stringArray[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}