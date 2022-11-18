namespace PedraPapelTesoura.Domain
{
    public class PrimeiroJogadorEscolheTesouraStrategy : IPedraPapelTesouraStrategy
    {
        public OpcaoJogador OpcaoPrimeiroJogador()
            => OpcaoJogador.Tesoura;

        public string Resultado(OpcaoJogador opcaoJogadorDois)
        {
            if (opcaoJogadorDois == OpcaoJogador.Papel || opcaoJogadorDois == OpcaoJogador.Lagarto)
                return "Jogador 1 ganhou!";
            else
                return "Jogador 2 ganhou!";
        }
    }
}