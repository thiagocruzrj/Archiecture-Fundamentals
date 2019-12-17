namespace DesignPatterns.Adapter
{
    public class ExecucaoAdapter
    {
        public static void Executar()
        {
            var pagamentoLogPadrão = new TransicaoService(new Logger());
            pagamentoLogPadrão.RealizarTransicao();

            var pagamentoLogCustom = new TransicaoService(new LogAdapter(new LogNetMasterService()));
            pagamentoLogCustom.RealizarTransicao();
        }       
    }
}