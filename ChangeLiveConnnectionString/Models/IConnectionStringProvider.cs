namespace ChangeLiveConnnectionString.Models
{
    public interface IConnectionStringProvider
    {
        void Set(string value);

        string Get();

        string GetKey();

        List<Key> GetKeys();
    }
}
