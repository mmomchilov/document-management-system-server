using System.Threading;
using System.Threading.Tasks;

namespace Pirina.Kernel.Transport
{
    public interface ITransportDispatcher
    {
        ITransportManager TransportManager { get; }
        Task SendMessage<TMessage>(TMessage message, CancellationToken cancellationToken) where TMessage : Pirina.Kernel.Messaging.Message;
    }
}
