using System;
using System.Threading;
using System.Threading.Tasks;
using Pirina.Kernel.DependencyResolver;

namespace Pirina.Kernel.Initialisation
{
    public interface IRunnable
    {
        Task Run(IDependencyResolver resolver, Func<ServiceContext> contextFactory, CancellationToken cancellationToken);
    }
}