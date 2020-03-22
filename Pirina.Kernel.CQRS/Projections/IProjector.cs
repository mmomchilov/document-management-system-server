using System;
using System.Linq;

namespace Pirina.Kernel.CQRS.Projections
{
    public interface IProjector<TModel> : IDisposable where TModel : class
    {
        IQueryable<TModel> GetAll();
    }
}