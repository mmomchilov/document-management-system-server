using System.Threading;
using System.Threading.Tasks;

namespace Pirina.Kernel.Messaging.Dispatching
{
    public interface IMessageDispatcher
    {
        Task SendMessage(Message message, CancellationToken cancallationToken);
    }
}