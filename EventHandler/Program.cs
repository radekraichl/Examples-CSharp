EventProgram eventProgram = new();

// Lambda
eventProgram.DemoEvent += (sender, e) => Console.WriteLine($"Lambda method 1 - sender: {sender}, arg1: {(e as CustomEventArgs).Argument1}");
eventProgram.DemoEvent += (sender, e) => Console.WriteLine($"Lambda method 2 - sender: {sender}, arg2: {(e as CustomEventArgs).Argument2}");

// Equivalents
eventProgram.DemoEvent += TestMethod;
eventProgram.DemoEvent += new EventHandler(TestMethod);

// Performance
EventHandler savedEvent = TestMethod;   // cache method for performance
eventProgram.DemoEvent += savedEvent;
eventProgram.DemoEvent += savedEvent;

eventProgram.OnDemoEvent();

/// <summary>
/// Test method
/// </summary>
static void TestMethod(object sender, EventArgs e)
{
    Console.WriteLine($"Test method - sender: {sender}, args: {e}");
}
