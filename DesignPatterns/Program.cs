using System;
using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFatory;
using DesignPatterns.Adapter;
using DesignPatterns.Composite;
using DesignPatterns.Facade;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Singleton;

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
                    ExecucaoFactoryMethod.Executar();
                    break;
                case '3':
                    ExecucaoSingleton.Executar();
                    break;
                case '4':
                    ExecucaoAdapter.Executar();
                    break;
                case '5':
                    ExecucaoFacade.Executar();
                    break;
                case '6':
                    ExecucaoComposite.Executar();
                    break;
                case '7':
                    ExecucaoCommand.Executar();
                    break;
                case '8':
                    ExecucaoStrategy.Executar();
                    break;
                case '9':
                    ExecucaoObserver.Executar();
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
