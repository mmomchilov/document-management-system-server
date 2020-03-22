using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Pirina.Kernel.Web
{
    public interface IResourceRetriever
    {
        Task<string> GetAsync(string address, CancellationToken cancel);
        Task<string> PutAsyncAsJson(string address, string contentValue, CancellationToken cancel);
        Task<string> PostAsyncAsJson(string address, string contentValue, CancellationToken cancel);
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
    }
}