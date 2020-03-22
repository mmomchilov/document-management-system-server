using System.Threading.Tasks;
using Pirina.Kernel.Data;

namespace Pirina.Kernel.Authentication.Services
{
    public interface ITokenProviderService<TUser, TKey> where TUser : class, IHasID
    {
        Task<string> GenerateUserToken(string purpose, TUser user);
    }
}