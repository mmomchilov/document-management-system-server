using System;

namespace Pirina.Kernel.DependencyResolver
{
    public interface IRepositoryResolver
	{
		object ResolveRepository(Type type);
	}
}
