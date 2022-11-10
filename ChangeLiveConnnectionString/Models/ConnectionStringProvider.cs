namespace ChangeLiveConnnectionString.Models
{
    public class ConnectionStringProvider : IConnectionStringProvider
    {
        private string value;
        private string current;
        private Dictionary<string, string> connectionStrings = new()
        {
            { "A1", "Server=DESKTOP-1446PBQ;Database=DwarfSelfies.Database.07112022;Trusted_Connection=True;" },
            { "B1", "Server=DESKTOP-1446PBQ;Database=DwarfSelfies.Database.07112022.2;Trusted_Connection=True;" }
        };

        public ConnectionStringProvider()
        {
            this.current = this.connectionStrings["A1"];
        }

        public void Set(string value)
        {
            this.value = value;
            this.current = this.connectionStrings[this.value];
        }

        public string GetKey() => this.value;

        public string Get()
        {
            return this.current;
        }

        public List<Key> GetKeys()
        {
            return this.connectionStrings.Select(item => new Key() { Value = item.Key }).ToList();
        }
    }
}
