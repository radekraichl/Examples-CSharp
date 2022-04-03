using System;
using System.Collections;

namespace EnumerableClass
{
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
