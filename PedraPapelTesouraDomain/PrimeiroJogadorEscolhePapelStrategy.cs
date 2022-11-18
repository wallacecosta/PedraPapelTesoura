namespace PedraPapelTesoura.Domain
{
    public class PrimeiroJogadorEscolhePapelStrategy : IPedraPapelTesouraStrategy
    {
        public OpcaoJogador OpcaoPrimeiroJogador()
            => OpcaoJogador.Papel;

        public string Resultado(OpcaoJogador opcaoJogadorDois)
        {
            if (opcaoJogadorDois == OpcaoJogador.Pedra || opcaoJogadorDois == OpcaoJogador.Spock)
                return "Jogador 1 ganhou!";
            else
                return "Jogador 2 ganhou!";
        }
    }
}