﻿using System;
using System.Threading.Tasks;

namespace Pirina.Kernel.Security.Validation
{
    public interface IBackchannelCertificateValidationRule
    {
        Task Validate(BackchannelCertificateValidationContext context, Func<BackchannelCertificateValidationContext, Task> next);
    }
}