using System;

namespace DesignPatterns.AbstractFatory
{
    // Abstract Product
    public abstract class Veiculo
    {
        protected Veiculo(string modelo, Porte porte)
        {
            Modelo = modelo;
            Porte = porte;
        }

        public string Modelo { get; set; }
        public Porte Porte { get; set; }
    }

    public enum Porte
    {
        Pequeno = 1,
        Medio = 2,
        Grande = 3
    }

    public class VeiculoPequeno : Veiculo
    {
        public VeiculoPequeno(string modelo, Porte porte) : base(modelo, porte)
        {

        }
    }

    public class VeiculoMedio : Veiculo
    {
        public VeiculoMedio(string modelo, Porte porte) : base(modelo, porte)
        {
            
        }
    }

    public class VeiculoGrande : Veiculo
    {
        public VeiculoGrande(string modelo, Porte porte) : base(modelo, porte)
        {
            
        }
    }

    public class VeiculoCreator
    {
        public static Veiculo Criar(string modelo, Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new VeiculoPequeno(modelo, porte);
                case Porte.Medio:
                    return new VeiculoMedio(modelo, porte);
                case Porte.Grande:
                    return new VeiculoGrande(modelo, porte);
                default:
                    throw new ApplicationException("Porte de veiculo desconhecido.");
            }
        }
    }
}