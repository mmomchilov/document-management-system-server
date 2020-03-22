using System.Threading.Tasks;
using Pirina.Kernel.Authorisation.Contexts;

namespace Pirina.Kernel.Authorisation
{
    public interface IAuthorizationServerProvider
    {
        Task TokenEndpointResponse<TContext>(TContext context) where TContext : class, ITokenEndpointResponseContext;
    }
}