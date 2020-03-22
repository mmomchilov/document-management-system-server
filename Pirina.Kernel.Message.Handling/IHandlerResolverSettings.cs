using System.Collections.Generic;
using System.Reflection;

namespace Pirina.Kernel.Message.Handling
{
    public interface IHandlerResolverSettings
    {
        IEnumerable<Assembly> LimitAssembliesTo { get; }
        bool HasCustomAssemblyList { get; }
    }
}