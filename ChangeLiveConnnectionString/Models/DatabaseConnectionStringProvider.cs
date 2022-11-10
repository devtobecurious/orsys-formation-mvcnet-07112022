namespace ChangeLiveConnnectionString.Models
{
    public class DatabaseConnectionStringProvider : IConnectionStringProvider
    {
        public DatabaseConnectionStringProvider() // A injecter ici
        {

        }

        public string Get()
        {
            // Vous vous connectez à votre base de données
            return string.Empty;
        }

        public string GetKey()
        {
            throw new NotImplementedException();
        }

        public List<Key> GetKeys()
        {
            throw new NotImplementedException();
        }

        public void Set(string value)
        {
            throw new NotImplementedException();
        }
    }
}
