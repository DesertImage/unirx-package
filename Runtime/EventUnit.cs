namespace DesertImage.Events
{
    public class EventUnit : IEventUnit
    {
        protected readonly EventsManager EventsManager = new EventsManager();

        public void ListenEvent<TEvent>(IListen listener)
        {
            EventsManager.Add<TEvent>(listener);
        }

        public void UnlistenEvent<TEvent>(IListen listener)
        {
            EventsManager.Remove<TEvent>(listener);
        }

        public void SendEvent<TEvent>(TEvent @event)
        {
            EventsManager.Send(@event);
        }
    }
}