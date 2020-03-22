using System.Threading.Tasks;

namespace Pirina.Kernel.Authorisation
{
    public interface IContextValidator<TContext>
    {
        Task ValidateContext(TContext context);
    }
}