using System;

public class EventPublisher
{
  public event EventHandler<string> MyEvent;

  public void TriggerEvent(string message)
  {
    if (MyEvent != null)
    {
      MyEvent(this, message);
    }
  }
}
public class EventSubscriber
{
  public EventSubscriber(EventPublisher publisher)
  {
    publisher.MyEvent += HandleEvent;
  }
  private void HandleEvent(object sender, string message)
  {
    Console.WriteLine("Event received: " + message);
  }
}

class Program
{
  static void Main()
  {
    EventPublisher publisher = new EventPublisher();
    EventSubscriber subscriber = new EventSubscriber(publisher);

    publisher.TriggerEvent("Hello from the event!");
  }
}