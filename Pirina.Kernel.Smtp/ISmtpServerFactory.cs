namespace Pirina.Kernel.Smtp
{
    public interface ISmtpServerFactory
    {
        ISmtpServer CreateInstance();
    }
}