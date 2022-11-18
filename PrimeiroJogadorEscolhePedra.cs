namespace PedraPapelTesoura
{
    public class PrimeiroJogadorEscolhePedra : IPedraPapelTesouraStrategy
    {
        public OpcaoJogador OpcaoPrimeiroJogador()
            => OpcaoJogador.Pedra;

        public string Resultado(OpcaoJogador opcaoJogadorDois)
        {
            if (opcaoJogadorDois == OpcaoJogador.Lagarto || opcaoJogadorDois == OpcaoJogador.Tesoura)
                return "Jogador 1 ganhou!";
            else
                return "Jogador 2 ganhou!";
        }
    }
}
