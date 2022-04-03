using System.Collections;
using System.Collections.Generic;

namespace EnumerableEnumeratorClass
{
    class Employees : IEnumerable, IEnumerator
    {
        private readonly List<Person> employees;

        private int position = -1;

        public Employees()
        {
            employees = new()
            {
                new Person("Franta", 28),
                new Person("Hanka", 38),
                new Person("Pepa", 33),
                new Person("Veronika", 36)
            };
        }

        public int Count => employees.Count;

        // Indexer
        public Person this[int i]
        {
            get => employees[i];
        }

        // IEnumerable
        public IEnumerator GetEnumerator() => this;

        // IEnumerator
        public void Reset() => position = -1;

        public object Current => employees[position];
            
        public bool MoveNext()
        {
            position++;
            return position < employees.Count;
        }
    }
}
