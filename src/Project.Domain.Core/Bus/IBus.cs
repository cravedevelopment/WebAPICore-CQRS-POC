using Project.Domain.Core.Commands;
using Project.Domain.Core.Events;

namespace Project.Domain.Core.Bus
{
    public interface IBus
    {
        void SendCommand<T>(T theCommand) where T : Command;
        void RaiseEvent<T>(T theEvent) where T : Event;
    }
}
