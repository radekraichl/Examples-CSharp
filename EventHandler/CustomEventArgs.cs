internal class CustomEventArgs : EventArgs
{
    public int Argument1 { get; } = 10;

    public int Argument2 { get; } = 20;

    public override string ToString() => $"Argument1: {Argument1}, Argument2: {Argument2}";
}
