using System;

namespace Pirina.Kernel.Authentication
{
    public interface ICredentialsProvider<T>
    {
        T GetCredential(Uri uri, string authType);
    }
}