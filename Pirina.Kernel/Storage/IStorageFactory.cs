using System.Threading.Tasks;

namespace Pirina.Kernel.Storage
{
    public interface IStorageFactory<TIdentifier>
    {
        Task<IStorage<TIdentifier>> GetStorage<T>(T connection);
    }
}
