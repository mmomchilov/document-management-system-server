using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pirina.Kernel.Mime
{
    public interface IMimeMessageFactory
    {
        Task<IMimeMessage> CreateInstance(
            IEnumerable<MimeHeader> headers,
            IEnumerable<MimeEntity> bodyParts,
            IEnumerable<MimeEntity> attachments);
    }
}
