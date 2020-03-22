using System.Threading;
using System.Threading.Tasks;
using Pirina.Kernel.Mime;
using Pirina.Kernel.Smtp.IO;

namespace Pirina.Kernel.Smtp.Mime
{
    public interface IMimeMessageDeserializer
    {
        Task<IMimeMessage> DeserializeAsync(INetworkClient networkClient, CancellationToken cancellationToken = default(CancellationToken));
    }
}