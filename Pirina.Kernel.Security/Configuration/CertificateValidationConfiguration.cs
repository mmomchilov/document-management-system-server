using System.Collections.Generic;
using Pirina.Kernel.Security.Security;

namespace Pirina.Kernel.Security.Configuration
{
    public class CertificateValidationConfiguration
    {
        public CertificateValidationConfiguration()
        {
            this.ValidationRules = new List<ValidationRuleDescriptor>();
        }
        public X509CertificateValidationMode X509CertificateValidationMode { get; set; }
       
        public ICollection<ValidationRuleDescriptor> ValidationRules { get; }
    }
}