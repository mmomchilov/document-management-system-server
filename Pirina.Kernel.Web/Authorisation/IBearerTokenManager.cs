using System.Threading;
using System.Threading.Tasks;

namespace Pirina.Kernel.Web.Authorisation
{
    public interface IBearerTokenManager
    {
        Task<TokenDescriptor> GetToken(IBearerTokenContext tokenContext, CancellationToken cancellationToken);
    }
}