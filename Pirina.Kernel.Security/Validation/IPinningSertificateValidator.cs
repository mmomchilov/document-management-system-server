﻿using System;
using System.Threading.Tasks;

namespace Pirina.Kernel.Security.Validation
{
    public interface IPinningSertificateValidator
    {
        Task Validate(object sender, BackchannelCertificateValidationContext context, Func<object, BackchannelCertificateValidationContext, Task> next);
    }
}