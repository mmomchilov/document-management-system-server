using System;

namespace Pirina.Kernel.Resolvers
{
    public interface ITypeResolver
    {
        Type ResolverUnderlyingType(Type type);
    }
}