namespace PedraPapelTesoura.Domain
{
    public class PrimeiroJogadorEscolheInvalidoStrategy : IPedraPapelTesouraStrategy
    {
        public OpcaoJogador OpcaoPrimeiroJogador()
            => OpcaoJogador.Invalido;

        public string Resultado(OpcaoJogador opcaoJogadorDois)
            => "O Jogador 1 escolheu uma Opção Inválida";
    }
}