using DesertImage;

namespace DesertImage.Events
{
    public interface IEventUnit
    {
        void ListenEvent<TEvent>(IListen listener);
        void UnlistenEvent<TEvent>(IListen listener);
        void SendEvent<TEvent>(TEvent @event);
    }
}