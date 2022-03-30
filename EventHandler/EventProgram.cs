internal class EventProgram
{
    public EventHandler DemoEvent;

    public void OnDemoEvent()
    {
        DemoEvent?.Invoke(this, new MyEventArgs());
    }
}
