using System.Net.Http;
using System.Net.Http.Headers;

namespace Pirina.Kernel.Web.Authorisation
{
    public interface IBearerTokenContext
    {
        string GrantType { get; }
        HttpContent Content { get; }
        void HeaderHandler(HttpRequestHeaders headers);
        string ContextKey();
    }
}