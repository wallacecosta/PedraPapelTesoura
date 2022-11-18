using PedraPapelTesoura.Domain;

namespace PedraPapelTesouraUnitTests
{
    public class PedraPapelTesouraUnitTest
    {
        private const string JOGADOR_HUM_GANHOU = "Jogador 1 ganhou!";

        [Fact]
        public void Papel_Ganha_Pedra()
        {
            var opcaoJogadorHum = OpcaoJogador.Papel;
            var opcaoJogadorDois = OpcaoJogador.Pedra;
            var jogo = new PedraPapelTesouraContext(opcaoJogadorHum);
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Papel_Ganha_Spock()
        {
            var opcaoJogadorHum = OpcaoJogador.Papel;
            var opcaoJogadorDois = OpcaoJogador.Spock;
            var jogo = new PedraPapelTesouraContext(opcaoJogadorHum);
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Pedra_Ganha_Tesoura()
        {
            var opcaoJogadorHum = OpcaoJogador.Pedra;
            var opcaoJogadorDois = OpcaoJogador.Tesoura;
            var jogo = new PedraPapelTesouraContext(opcaoJogadorHum);
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Pedra_Ganha_Lagarto()
        {
            var opcaoJogadorHum = OpcaoJogador.Pedra;
            var opcaoJogadorDois = OpcaoJogador.Lagarto;
            var jogo = new PedraPapelTesouraContext(opcaoJogadorHum);
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Tesoura_Ganha_Papel()
        {
            var opcaoJogadorHum = OpcaoJogador.Tesoura;
            var opcaoJogadorDois = OpcaoJogador.Papel;
            var jogo = new PedraPapelTesouraContext(opcaoJogadorHum);
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Tesoura_Ganha_Lagarto()
        {
            var opcaoJogadorHum = OpcaoJogador.Tesoura;
            var opcaoJogadorDois = OpcaoJogador.Lagarto;
            var jogo = new PedraPapelTesouraContext(opcaoJogadorHum);
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Spock_Ganha_Tesoura()
        {
            var opcaoJogadorHum = OpcaoJogador.Spock;
            var opcaoJogadorDois = OpcaoJogador.Tesoura;
            var jogo = new PedraPapelTesouraContext(opcaoJogadorHum);
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Spock_Ganha_Pedra()
        {
            var opcaoJogadorHum = OpcaoJogador.Spock;
            var opcaoJogadorDois = OpcaoJogador.Pedra;
            var jogo = new PedraPapelTesouraContext(opcaoJogadorHum);
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }


        [Fact]
        public void Lagarto_Ganha_Spock()
        {
            var opcaoJogadorHum = OpcaoJogador.Lagarto;
            var opcaoJogadorDois = OpcaoJogador.Spock;
            var jogo = new PedraPapelTesouraContext(opcaoJogadorHum);
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }

        [Fact]
        public void Lagarto_Ganha_Papel()
        {
            var opcaoJogadorHum = OpcaoJogador.Lagarto;
            var opcaoJogadorDois = OpcaoJogador.Papel;
            var jogo = new PedraPapelTesouraContext(opcaoJogadorHum);
            var resultado = jogo.ObterResultado(opcaoJogadorDois);

            Assert.Equal(JOGADOR_HUM_GANHOU, resultado);
        }
    }
}