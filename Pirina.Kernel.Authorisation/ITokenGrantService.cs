using System.Threading.Tasks;

namespace Pirina.Kernel.Authorisation
{
    public interface ITokenGrantService<TContext>
    {
        Task GrantToken(TContext context);
    }
}