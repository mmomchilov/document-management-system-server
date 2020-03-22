using System.Threading.Tasks;
using Pirina.Kernel.Authentication.Services;

namespace Pirina.Kernel.Authentication.AuthenticatonManagers
{
    public interface IAuthenticationManager
    {
        Task<UserInfoResult> FindUserByUserName(AuthenicationContext authenicationContext);
        Task<UserInfoResult> FindUserByEmail(AuthenicationContext authenicationContext);
    }
}