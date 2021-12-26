using EventHandlerGeneric;

KeyEvent keyEvent = new();
ConsoleKeyInfo key;
int count = 0;

// Use a lambda expression to display the keypress.
keyEvent.KeyPress += (sender, e) => Console.WriteLine(" Received keystroke: " + e.Char);

// Use a lambda expression to count keypresses.
keyEvent.KeyPress += (sender, e) => count++;            // count is an outer variable

do
{
    key = Console.ReadKey();
    keyEvent.OnKeyPress(key.KeyChar);
}
while (key.KeyChar != '.');

Console.WriteLine(count + " keys pressed.");