using System;

namespace DesignPatterns.FactoryMethod
{
    public class SqlServerConnector : DbConnector
    {
        public SqlServerConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco SqlServer...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}