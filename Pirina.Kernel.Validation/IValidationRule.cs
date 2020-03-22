using System;
using System.Threading.Tasks;

namespace Pirina.Kernel.Validation
{
    public interface IValidationRule
    {
        Task Validate(ValidationContext context, Func<ValidationContext, Task> next);
    }
}