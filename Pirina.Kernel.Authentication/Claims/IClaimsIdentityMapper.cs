using System.Security.Claims;
using System.Threading.Tasks;

namespace Pirina.Kernel.Authentication.Claims
{
    public interface IClaimsIdentityMapper<TResult>
    {
        Task<TResult> MapIClaimsIdentity(ClaimsIdentity identity);
    }
}