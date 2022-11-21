using PedraPapelTesoura.Domain;

namespace PedraPapelTesouraUnitTests
{
    public class PedraPapelTesouraUnitTest
    {
        private const string JOGADOR_HUM_GANHOU = "Jogador 1 ganhou!";

        [Fact]
        public void Papel_Ganha_Pedra()
        {
            var opcaoJogadorDois = OpcaoJogador.Pedra;
            var jogo = new PedraPapelTesouraContext(new PrimeiroJogadorEscolhePapelStrategy());
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Papel_Ganha_Spock()
        {
            var opcaoJogadorDois = OpcaoJogador.Spock;
            var jogo = new PedraPapelTesouraContext(new PrimeiroJogadorEscolhePapelStrategy());
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Pedra_Ganha_Tesoura()
        {
            var opcaoJogadorDois = OpcaoJogador.Tesoura;
            var jogo = new PedraPapelTesouraContext(new PrimeiroJogadorEscolhePedraStrategy());
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Pedra_Ganha_Lagarto()
        {
            var opcaoJogadorDois = OpcaoJogador.Lagarto;
            var jogo = new PedraPapelTesouraContext(new PrimeiroJogadorEscolhePedraStrategy());
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Tesoura_Ganha_Papel()
        {
            var opcaoJogadorDois = OpcaoJogador.Papel;
            var jogo = new PedraPapelTesouraContext(new PrimeiroJogadorEscolheTesouraStrategy());
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Tesoura_Ganha_Lagarto()
        {
            var opcaoJogadorDois = OpcaoJogador.Lagarto;
            var jogo = new PedraPapelTesouraContext(new PrimeiroJogadorEscolheTesouraStrategy());
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Spock_Ganha_Tesoura()
        {
            var opcaoJogadorDois = OpcaoJogador.Tesoura;
            var jogo = new PedraPapelTesouraContext(new PrimeiroJogadorEscolheSpockStrategy());
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Spock_Ganha_Pedra()
        {
            var opcaoJogadorDois = OpcaoJogador.Pedra;
            var jogo = new PedraPapelTesouraContext(new PrimeiroJogadorEscolheSpockStrategy());
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }


        [Fact]
        public void Lagarto_Ganha_Spock()
        {
            var opcaoJogadorDois = OpcaoJogador.Spock;
            var jogo = new PedraPapelTesouraContext(new PrimeiroJogadorEscolheLagartoStrategy());
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Lagarto_Ganha_Papel()
        {
            var opcaoJogadorDois = OpcaoJogador.Papel;
            var jogo = new PedraPapelTesouraContext(new PrimeiroJogadorEscolheLagartoStrategy());
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Primeiro_Jogador_Escolheu_Opcao_Invalida()
        {
            var opcaoJogadorDois = OpcaoJogador.Papel;
            var jogo = new PedraPapelTesouraContext(new PrimeiroJogadorEscolheInvalidoStrategy());
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal("O Jogador 1 escolheu uma Opção Inválida", resultado);
        }

        [Fact]
        public void Segundo_Jogador_Escolheu_Opcao_Invalida()
        {
            var opcaoJogadorDois = OpcaoJogador.Invalido;
            var jogo = new PedraPapelTesouraContext(new PrimeiroJogadorEscolhePapelStrategy());
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal("O Jogador 2 escolheu uma Opção Inválida", resultado);
        }


        [Fact]
        public void Empate()
        {
            var opcaoJogadorDois = OpcaoJogador.Papel;
            var jogo = new PedraPapelTesouraContext(new PrimeiroJogadorEscolhePapelStrategy());
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal("Empate", resultado);
        }
    }
}