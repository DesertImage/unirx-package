using DesertImage;

namespace Runtime
{
    public interface IEventsProvider
    {
        void Listen<TEvent>(IListen listener);
        void Unlisten<TEvent>(IListen listener);
        void Send<TEvent>(TEvent @event);
    }
}