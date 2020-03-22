using System;
using System.Net.Http.Headers;
using Pirina.Kernel.Configuration;

namespace Pirina.Kernel.Web
{
    public interface IHttpResourceRetriever : IResourceRetriever
    {
        bool RequireHttps { get; set; }
        TimeSpan Timeout { get; set; }
        long MaxResponseContentBufferSize { get; set; }
        Action<HttpRequestHeaders> HeadersHandler { set; }
        ICustomConfigurator<IHttpResourceRetriever> HttpDocumentRetrieverConfigurator { set; }
    }
}