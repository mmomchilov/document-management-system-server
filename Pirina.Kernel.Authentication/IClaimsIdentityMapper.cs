using System.Security.Claims;
using System.Threading.Tasks;

namespace Pirina.Kernel.Authentication
{
    public interface IClaimsIdentityMapper<TResult>
    {
        Task<TResult> MapClaimsIdentity(ClaimsIdentity identity);
    }
}