using System.Threading;
using System.Threading.Tasks;
using Pirina.Kernel.Smtp.Protocol;

namespace Pirina.Kernel.Smtp.Transport
{
    public interface IMessageTransport
    {
        Task<bool> DispatchAsync(ISessionContext context, CancellationToken cancellationToken);
    }
}