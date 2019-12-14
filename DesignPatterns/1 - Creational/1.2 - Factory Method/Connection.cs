using System;

namespace DesignPatterns.FactoryMethod
{
    public class Connection
    {
        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }
        public bool Opened { get; set; }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine("Executando comando: " + command);
        }
        
        public void Open()
        {
            Opened = true;
            Console.WriteLine("Conexão aberta");
        }

        public void Close()
        {
            Opened = true;
            Console.WriteLine("Conexão fechada");
        }
    }
}