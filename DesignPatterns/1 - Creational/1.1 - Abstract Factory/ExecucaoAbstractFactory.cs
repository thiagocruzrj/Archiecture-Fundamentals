using System.Collections.Generic;

namespace DesignPatterns.AbstractFactory
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            var veiculosSocorro = new List<Veiculo>
            {
                VeiculoCreator.Criar("Celta", Porte.Pequeno),
                VeiculoCreator.Criar("Sentra", Porte.Medio),
                VeiculoCreator.Criar("Evoke", Porte.Grande)
            };
            veiculosSocorro.ForEach(v => AutoSocorro.CriarAutoSocorro(v).RealizarAtendimento());
        }
    }
}