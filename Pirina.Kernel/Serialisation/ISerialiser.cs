using System.IO;
using System.Threading.Tasks;

namespace Pirina.Kernel.Serialisation
{
    public interface ISerialiser
    {
        Task<Stream> Serialise(object obj);

        Task<object> Deserialise(Stream stream);

        Task<T> Deserialise<T>(Stream stream);
    }
}