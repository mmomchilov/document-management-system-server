﻿using System.Security;

namespace Pirina.Kernel.Security.CertificateManagement
{
    public class FileCertificateContext : CertificateContext
    {
        public string CertificatePath { get; set; }
        public SecureString Password { get; set; }
    }
}