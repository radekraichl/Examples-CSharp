namespace EventAction
{
    class Program
    {
        private static int count = 0;
        private static event Action EnterPressed;

        static void Main()
        {
            ConsoleKeyInfo keyInfo;

            EnterPressed += OnEnterPressed;
            EnterPressed += () => count++;

            do
            {
                keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    EnterPressed?.Invoke();
                }
            }
            while (keyInfo.Key != ConsoleKey.Escape);
        }

        private static void OnEnterPressed()
        {
            Console.WriteLine($"ENTER pressed ({count})");
        }
    }
}
