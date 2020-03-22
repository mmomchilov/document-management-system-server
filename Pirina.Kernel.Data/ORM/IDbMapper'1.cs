using System.Threading.Tasks;

namespace Pirina.Kernel.Data.ORM
{
    public interface IDbMapper<TBuilder>
    {
        Task Configure(TBuilder builder, IDbCustomConfiguration configuration);
    }
}