namespace PedraPapelTesoura.Domain
{
    public class PedraPapelTesouraContext
    {
        private IPedraPapelTesouraStrategy _strategy;

        public PedraPapelTesouraContext(IPedraPapelTesouraStrategy strategy)
            => _strategy = strategy;

        public string ObterResultado(OpcaoJogador opcaoJogadorDois)
        {
            if (opcaoJogadorDois == OpcaoJogador.Invalido)
                return "O Jogador 2 escolheu uma Opção Inválida";

            if (_strategy.OpcaoPrimeiroJogador() == opcaoJogadorDois)
                return "Empate";

            return _strategy.Resultado(opcaoJogadorDois);
        }
    }
}
