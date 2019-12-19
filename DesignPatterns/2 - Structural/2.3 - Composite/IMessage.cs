namespace DesignPatterns.Composite
{
    public interface IMessage
    {
        string Nome { get; set; }
        void ExibirMensagens(int sub);
    }
}