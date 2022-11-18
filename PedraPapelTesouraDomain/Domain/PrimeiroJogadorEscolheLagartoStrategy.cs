namespace PedraPapelTesoura.Domain
{
    public class PrimeiroJogadorEscolheLagartoStrategy : IPedraPapelTesouraStrategy
    {
        public OpcaoJogador OpcaoPrimeiroJogador()
            => OpcaoJogador.Lagarto;

        public string Resultado(OpcaoJogador opcaoJogadorDois)
        {
            if (opcaoJogadorDois == OpcaoJogador.Spock || opcaoJogadorDois == OpcaoJogador.Papel)
                return "Jogador 1 ganhou!";
            else
                return "Jogador 2 ganhou!";
        }
    }
}