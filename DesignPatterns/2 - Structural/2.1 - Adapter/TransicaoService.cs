namespace DesignPatterns.Adapter
{
    // Client
    public class TransicaoService
    {
        private readonly ILogger _logger;

        public TransicaoService(ILogger logger)
        {
            _logger = logger;
        }

        public void RealizarTransicao()
        {
            _logger.Log("Transicao Realizada");
        }
    }
}