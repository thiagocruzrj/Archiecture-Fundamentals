using System;
using DesignPatterns.AbstractFatory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a Opção: ");
            Console.WriteLine("-------------------- ");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("-------------------- ");
            Console.WriteLine("1 - Abstract Factory ");
            Console.WriteLine("2 - Factory Method ");
            Console.WriteLine("3 - Singleton ");
            Console.WriteLine("Structural Patterns");
            Console.WriteLine("-------------------- ");
            Console.WriteLine("4 - Adapter");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("-------------------- ");
            Console.WriteLine("6 - Command");
            Console.WriteLine("7 - Strategy");
            Console.WriteLine("8 - Observer");
            Console.WriteLine("-------------------- ");

            var opcao = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("");

            switch (opcao.KeyChar)
            {
                case '1':
                    ExecucaoAbstractFactory.Executar();
                    break;
                case '2':
                    ExecucaoAbstractFactory.Executar();
                    break;
                case '3':
                    ExecucaoAbstractFactory.Executar();
                    break;
                case '4':
                    ExecucaoAbstractFactory.Executar();
                    break;
                case '5':
                    ExecucaoAbstractFactory.Executar();
                    break;
                case '6':
                    ExecucaoAbstractFactory.Executar();
                    break;
                case '7':
                    ExecucaoAbstractFactory.Executar();
                    break;
                case '8':
                    ExecucaoAbstractFactory.Executar();
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
