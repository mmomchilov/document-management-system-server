using System;
using System.Collections.Generic;
using Pirina.Kernel.Data.Tenancy;

namespace Pirina.Kernel.Data.ORM
{
    public interface IDbCustomConfiguration
    {
        ICollection<ISeeder> Seeders { get; }
        Func<IEnumerable<Type>> ModelsFactory { get; }
        Func<ITenantManager> TenantManager { get; }
        Func<IEnumerable<IDbMapper>> ModelMappers { get; }
        string Schema { get; }
        string ModelKey { get; }
    }
}