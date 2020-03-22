using System.Net.Http.Headers;

namespace Pirina.Kernel.Web
{
    public interface IAuthorisationHeaderBuilder
    {
        AuthenticationHeaderValue BuildAuthorisationHeader();
    }
}