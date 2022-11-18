namespace PedraPapelTesoura
{
    public interface IPedraPapelTesouraStrategy
    {
        OpcaoJogador OpcaoPrimeiroJogador();
        string Resultado(OpcaoJogador opcaoJogadorDois);
    }
}
