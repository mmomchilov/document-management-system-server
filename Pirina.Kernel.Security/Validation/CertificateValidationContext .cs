﻿using System.Security.Cryptography.X509Certificates;

namespace Pirina.Kernel.Security.Validation
{
    public class CertificateValidationContext
    {
        public bool IsValid { get; private set; }
        public X509Certificate Certificate { get; }
        public CertificateValidationContext(X509Certificate certificate)
        {
            this.Certificate = certificate;
        }
        public void Validated()
        {
            this.IsValid = true;
        }
    }
}