using System.IO;

namespace Pirina.Kernel.Mime
{
    public interface IMimeMessageParser
    {
        IMimeMessage ParseMimeMessage(string content);
        IMimeMessage ParseMimeMessage(Stream content);
    }
}
