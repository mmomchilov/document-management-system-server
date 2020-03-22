using System.Threading.Tasks;

namespace Pirina.Kernel.Security.SecretManagement
{
    public interface ISecretManager
    {
        Task<string> GetSecret(SecretContext secretContext);
        Task<string> GetSecret(string secrentName);
        Task<string> GetSecret(string secrentName, string version);
    }
}