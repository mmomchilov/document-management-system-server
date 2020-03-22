namespace Pirina.Kernel.Authorisation
{
    public interface IAuthorizationServerOptionsProvider<TOptions>
    {
        TOptions GetOptions();
    }
}