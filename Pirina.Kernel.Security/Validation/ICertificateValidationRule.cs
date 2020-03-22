using System;
using System.Threading.Tasks;

namespace Pirina.Kernel.Security.Validation
{
    public interface ICertificateValidationRule
    {
        Task Validate(CertificateValidationContext context, Func<CertificateValidationContext, Task> next);
    }
}