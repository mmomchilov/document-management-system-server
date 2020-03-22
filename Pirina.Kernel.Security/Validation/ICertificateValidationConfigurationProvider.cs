using System;
using Pirina.Kernel.Security.Configuration;

namespace Pirina.Kernel.Security.Validation
{
    public interface ICertificateValidationConfigurationProvider : IDisposable
    {
        CertificateValidationConfiguration GetConfiguration(string federationPartyId);
        BackchannelConfiguration GeBackchannelConfiguration(string federationPartyId);
        BackchannelConfiguration GeBackchannelConfiguration(Uri partyUri);
    }
}