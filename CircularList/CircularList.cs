internal class CircularList<T> : List<T>
{
    private int index;

    public int Index
    {
        get => index;
        set
        {
            if (value > Count - 1)
            {
                throw new IndexOutOfRangeException(nameof(CircularList<T>));
            }

            index = value;
        }
    }

    public T Value
    {
        get => this[Index];
        set => this[Index] = value;
    }

    public void Next()
    {
        if (++index >= Count)
        {
            index = 0;
        }
    }
}
