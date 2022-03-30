
CircularList<string> circularList = new() { "raz", "dva", "tři" };

circularList.Index = 2;

// testovací smyčka
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(circularList.Value);
    circularList.Next();
}
