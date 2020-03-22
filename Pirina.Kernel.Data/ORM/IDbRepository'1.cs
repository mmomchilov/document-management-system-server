using System;
using Pirina.Kernel.Data.DataRepository;

namespace Pirina.Kernel.Data.ORM
{
    /// <summary>
    ///  Database repository
    /// </summary>
    public interface IDbRepository<T> : IDbRepository, IRepository<T, Guid>
		where T : class, IHasID<Guid>
	{
	}
}