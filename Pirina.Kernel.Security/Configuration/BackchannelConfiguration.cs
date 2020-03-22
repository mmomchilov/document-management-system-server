using System.Collections.Generic;
using Pirina.Kernel.Reflection;

namespace Pirina.Kernel.Security.Configuration
{
    public class BackchannelConfiguration
    {
        public BackchannelConfiguration()
        {
            this.Pins = new Dictionary<PinType, IEnumerable<string>>();
        }
        public TypeDescriptor BackchannelValidatorResolver { get; set; }
        public bool UsePinningValidation { get; set; }
        public IDictionary<PinType, IEnumerable<string>> Pins { get; }
    }
}