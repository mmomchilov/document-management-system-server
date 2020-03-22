using System.Threading.Tasks;

namespace Pirina.Kernel.Storage
{
    public interface IStorageConnectionManager<TClient> where TClient : class
    {
        Task<TClient> GetStorageClient();
    }
}
