namespace Pirina.Kernel.Storage
{
    public interface IStorageConfiguration
    {
        string ConnectionString { get; }
        string Key { get; }
        string ObjectName { get; }
    }
}
