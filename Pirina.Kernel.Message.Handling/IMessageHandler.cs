using System.Threading;
using System.Threading.Tasks;

namespace Pirina.Kernel.Message.Handling
{
    public interface IMessageHandler<TMessage> where TMessage : Pirina.Kernel.Messaging.Message
    {
		Task Handle(TMessage command, CancellationToken cancellationToken);
	}
}