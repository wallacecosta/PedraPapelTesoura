namespace PedraPapelTesoura.Domain
{
    public interface IPedraPapelTesouraStrategy
    {
        OpcaoJogador OpcaoPrimeiroJogador();
        string Resultado(OpcaoJogador opcaoJogadorDois);
    }
}
