namespace CircularListTest
{
    internal class CircularList<T> : List<T>
    {
        public int Index { get; set; }

        public T Value
        {
            get => this[Index];
            set => this[Index] = value;
        }

        public void Next()
        {
            if (++Index == Count)
            {
                Index = 0;
            }
        }
    }
}