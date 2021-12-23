internal class MyEventArgs : EventArgs
{
    public static int Argument1 => 10; 
    public static int Argument2 => 20;

    public override string ToString() => $"Argument1: {Argument1}, Argument2: {Argument2}";
}