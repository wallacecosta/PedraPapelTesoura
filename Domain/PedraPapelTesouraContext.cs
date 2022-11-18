namespace PedraPapelTesoura.Domain
{
    public class PedraPapelTesouraContext
    {
        private IPedraPapelTesouraStrategy _strategy;

        public PedraPapelTesouraContext(OpcaoJogador opcaoJogadorHum)
        {
            DefinirEstrategiaPrimeiroJogador(opcaoJogadorHum);
        }

        public string ObterResultado(OpcaoJogador opcaoJogadorDois)
        {
            if ((int)opcaoJogadorDois > 5)
                return "Opção inválida";

            if (_strategy.OpcaoPrimeiroJogador() == opcaoJogadorDois)
                return "Empate";

            return _strategy.Resultado(opcaoJogadorDois);
        }

        public void DefinirEstrategiaPrimeiroJogador(OpcaoJogador opcaoJogadorHum)
        {
            switch (opcaoJogadorHum)
            {
                case OpcaoJogador.Pedra:
                    _strategy = new PrimeiroJogadorEscolhePedraStrategy();
                    break;
                case OpcaoJogador.Papel:
                    _strategy = new PrimeiroJogadorEscolhePapelStrategy();
                    break;
                case OpcaoJogador.Tesoura:
                    _strategy = new PrimeiroJogadorEscolheTesouraStrategy();
                    break;
                case OpcaoJogador.Spock:
                    _strategy = new PrimeiroJogadorEscolheSpockStrategy();
                    break;
                case OpcaoJogador.Lagarto:
                    _strategy = new PrimeiroJogadorEscolheLagartoStrategy();
                    break;
                default:
                    throw new ArgumentException("Opção invalida!");
            }
        }
    }
}
