using System.Threading.Tasks;

namespace Pirina.Kernel.Web.Authorisation
{
    public interface IBearerTokenParser
    {
        Task<TokenDescriptor> Parse(string source);
    }
}