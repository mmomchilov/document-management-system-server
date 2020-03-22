using System;
using System.Collections.Generic;
using Pirina.Kernel.Mime;

namespace Pirina.Kernel.Smtp
{
    public interface IMessageTransaction
    {
        Guid TransactionId { get; }

        Guid TenantId { get; }

        Mailbox From { get; set; }

        IList<Mailbox> To { get; }

        IMimeMessage Message { get; set; }
        
        void Reset();
    }
}