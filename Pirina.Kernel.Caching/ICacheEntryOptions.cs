using System;

namespace Pirina.Kernel.Caching
{
	public interface ICacheEntryOptions
	{
        DateTimeOffset AbsoluteExpiration { get; set; }
        TimeSpan SlidingExpiration { get; set; }
    }
}