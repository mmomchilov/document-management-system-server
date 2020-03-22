﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pirina.Kernel.Smtp.Validation
{
    public interface IMessageValidator
    {
        Task<IEnumerable<string>> Validate(IMessageTransaction messageTransaction, CancellationToken cancellationToken);
    }
}