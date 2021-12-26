EventProgram eventProgram = new();

// Lambda
eventProgram.DemoEvent += (sender, e) => 
    Console.WriteLine($"Udalost - sender: {sender}, arg1: {(e as MyEventArgs).Argument1}");

// Ekvivalenty
eventProgram.DemoEvent += TestMethod;
eventProgram.DemoEvent += new EventHandler(TestMethod);

// Performance
EventHandler savedEvent = TestMethod;   // metoda se ulozi
eventProgram.DemoEvent += savedEvent;   // nevytvari se novy EventHandler
eventProgram.DemoEvent += savedEvent;

eventProgram.OnDemoEvent();

static void TestMethod(object sender, EventArgs e)
{
    Console.WriteLine($"Udalost - sender: {sender}, args: {e}");
}