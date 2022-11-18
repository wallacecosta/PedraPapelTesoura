namespace PedraPapelTesoura
{
    public class PrimeiroJogadorEscolheSpock : IPedraPapelTesouraStrategy
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