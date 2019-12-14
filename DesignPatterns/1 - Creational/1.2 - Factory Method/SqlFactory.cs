namespace DesignPatterns.FactoryMethod
{
    // Concrete creator
    public class SqlFactory : DbFactory
    {
        public override DbConnector CreateConnector(string connectionString)
        {
           return new SqlServerConnector(connectionString);
        }
    }
}