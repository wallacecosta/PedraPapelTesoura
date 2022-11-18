namespace PedraPapelTesoura.Domain
{
    public class PrimeiroJogadorEscolheSpockStrategy : IPedraPapelTesouraStrategy
    {
        public OpcaoJogador OpcaoPrimeiroJogador()
            => OpcaoJogador.Spock;

        public string Resultado(OpcaoJogador opcaoJogadorDois)
        {
            if (opcaoJogadorDois == OpcaoJogador.Tesoura || opcaoJogadorDois == OpcaoJogador.Pedra)
                return "Jogador 1 ganhou!";
            else
                return "Jogador 2 ganhou!";
        }
    }
}