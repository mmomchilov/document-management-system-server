using System;
using System.Threading.Tasks;
using Pirina.Kernel.DependencyResolver;

namespace Pirina.Kernel.Initialisation
{
    /// <summary>
    /// Initialises the server
    /// </summary>
    public interface IInitialiser
    {
        byte Order { get; }
        Type Type { get; }
        bool AutoDiscoverable { get; }
        Task Initialise(IDependencyResolver dependencyResolver);
    }
}