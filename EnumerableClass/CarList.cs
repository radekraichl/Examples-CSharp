using System.Collections;

namespace EnumerableClass
{
    /// <summary>
    /// Třída implementující IEnumerable která umožnuje procházení aut pomocí foreach
    /// </summary>
    class CarList : IEnumerable
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
}
