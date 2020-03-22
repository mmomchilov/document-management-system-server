﻿using System.Threading;
using System.Threading.Tasks;

namespace Pirina.Kernel.Transport
{
    public interface ITransportManager
    {
        Task Initialise(CancellationToken cancellationToken);
        Task Start(CancellationToken cancellationToken);
        Task Stop(CancellationToken cancallationToken);
        Task EnqueueMessage(byte[] message, CancellationToken cancellationToken);
        Task RegisterListener(IMessageListener listener);
    }
}