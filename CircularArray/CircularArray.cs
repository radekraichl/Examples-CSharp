using System;
using System.Collections;
using System.Collections.Generic;

namespace CircularArrayTest
{
    public class CircularArray<T> : IEnumerable<T>, IEnumerator<T>
    {
        protected T[] items;
        protected int _index = 0;
        protected bool loaded = false;
        protected int enumIdx = -1;

        /// <summary>
        /// Constructor that initializes the list with the 
        /// required number of items.
        /// </summary>
        public CircularArray(int numItems)
        {
            if (numItems <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numItems), numItems, "numItems can't be negative or 0.");
            }

            items = new T[numItems];
        }

        /// <summary>
        /// Gets/sets the item value at the current index.
        /// </summary>
        public T Value
        {
            get => items[_index]; 
            set => items[_index] = value;
        }

        /// <summary>
        /// Returns the count of the number of loaded items, up to
        /// and including the total number of items in the collection.
        /// </summary>
        public int Count => loaded ? items.Length : _index;

        /// <summary>
        /// Returns the length of the items array.
        /// </summary>
        public int Length
        {
            get => items.Length;
        }

        /// <summary>
        /// Gets/sets the value at the specified index.
        /// </summary>
        public T this[int index]
        {
            get
            {
                RangeCheck(index);
                return items[index];
            }
            set
            {
                RangeCheck(index);
                items[index] = value;
            }
        }

        /// <summary>
        /// Advances to the next item or wraps to the first item.
        /// </summary>
        public void Next()
        {
            if (++_index == items.Length)
            {
                _index = 0;
                loaded = true;
            }
        }

        /// <summary>
        /// Clears the list, resetting the current index to the 
        /// beginning of the list and flagging the collection as unloaded.
        /// </summary>
        public void Clear()
        {
            _index = 0;
            items.Initialize();
            loaded = false;
        }

        /// <summary>
        /// Sets all items in the list to the specified value, resets
        /// the current index to the beginning of the list and flags the
        /// collection as loaded.
        /// </summary>
        public void SetAll(T val)
        {
            _index = 0;
            loaded = true;

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = val;
            }
        }

        /// <summary>
        /// Internal indexer range check helper. Throws
        /// ArgumentOutOfRange exception if the index is not valid.
        /// </summary>
        protected void RangeCheck(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index), index, "Indexer cannot be less than 0.");
            }

            if (index >= items.Length)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(index),
                    index,
                    "Indexer cannot be greater than or equal to the number of items in the collection.");
            }
        }

        // Interface implementations:
        object IEnumerator.Current => Current == null ? -1 : Current;
        public IEnumerator<T> GetEnumerator() => this;
        IEnumerator IEnumerable.GetEnumerator() => this;
        public T Current => this[enumIdx];

        public bool MoveNext()
        {
            ++enumIdx;
            bool ret = enumIdx < Count;

            if (!ret)
            {
                Reset();
            }

            return ret;
        }

        public void Reset() => enumIdx = -1;

        public void Dispose() => GC.SuppressFinalize(this);
    }
}
