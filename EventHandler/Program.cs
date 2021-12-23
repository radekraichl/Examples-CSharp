EventProgram eventProgram = new();

// Ekvivalenty
eventProgram.DemoEvent = new EventHandler(TestMethod);
eventProgram.DemoEvent += (sender, e) => Console.WriteLine($"Udalost - sender: {sender}, args: {e}");

// Performance
EventHandler savedEvent = TestMethod;   // metoda se ulozi
eventProgram.DemoEvent += savedEvent;   // nevytvari se novy EventHandler
eventProgram.DemoEvent += savedEvent;
// -----------

eventProgram.OnDemoEvent();

static void TestMethod(object sender, EventArgs e)
{
    Console.WriteLine($"Udalost - sender: {sender}, args: {e}");
}