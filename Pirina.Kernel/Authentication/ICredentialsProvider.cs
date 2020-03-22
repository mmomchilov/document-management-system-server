using System.Net;

namespace Pirina.Kernel.Authentication
{
    public interface ICredentialsProvider : ICredentials, ICredentialsByHost
    {
    }
}