﻿using System.Security.Cryptography.X509Certificates;
using Pirina.Kernel.Security.Security;

namespace Pirina.Kernel.Security.Validation
{
    //
    // Summary:
    //     Interface for providing pinned certificate validation, which checks HTTPS communication
    //     against a known good list of certificates to protect against compromised or rogue
    //     CAs issuing certificates for hosts without the knowledge of the host owner.
    public interface ICertificateValidator
    {
        string FederationPartyId { get; }

        X509CertificateValidationMode X509CertificateValidationMode { get; }
        
        void Validate(X509Certificate2 certificate);
        void SetFederationPartyId(string federationPartyId);
    }
}