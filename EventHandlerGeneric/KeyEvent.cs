namespace EventHandlerGeneric;

internal class KeyEvent
{
    public event EventHandler<KeyEventArgs> KeyPress;

    // This is called when a key is pressed.
    public void OnKeyPress(char key)
    {
        KeyEventArgs keyEventArgs = new();

        if (KeyPress != null)
        {
            keyEventArgs.Char = key;
            KeyPress(this, keyEventArgs);
        }
    }
}
