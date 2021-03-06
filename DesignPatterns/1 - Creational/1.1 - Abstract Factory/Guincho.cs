using System;

namespace DesignPatterns.AbstractFactory
{
    // Abstract Product
    public abstract class Guincho
    {
        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);
        public Porte Porte { get; set; }
    }

    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte) {}

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine("Socorrendo carro Pequeno - Modelo " + veiculo.Modelo);
        }
    }

    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte) {}

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine("Socorrendo carro Medio - Modelo " + veiculo.Modelo);
        }
    }

    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte) {}

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine("Socorrendo carro Grande - Modelo " + veiculo.Modelo);
        }
    }

    public class GuinchoCreator
    {
        public static Guincho Criar(Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new GuinchoPequeno(porte);
                case Porte.Medio:
                    return new GuinchoMedio(porte);
                case Porte.Grande:
                    return new GuinchoGrande(porte);
                default:
                    throw new ApplicationException("Porte de guincho desconhecido.");
            }
        }
    }
}