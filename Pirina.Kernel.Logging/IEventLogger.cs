using System;
using System.Threading.Tasks;

namespace Pirina.Kernel.Logging
{
    public interface IEventLogger
    {
        Task Log(SeverityLevel level, Enum eventId, Type eventSource, Guid transactionId, string message);
        Task Log(SeverityLevel level, Enum eventId, Type eventSource, string message);
        Task Log(SeverityLevel level, Enum eventId, Type eventSource, Guid transactionId, Exception exception);
        Task Log(SeverityLevel level, Enum eventId, Type eventSource, Exception exception);
    }
}