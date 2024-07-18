using PedraPapelTesoura.Domain;
using PedraPapelTesouraDomain.Abstraction;

Iniciar();

static void Iniciar()
{
    Console.Clear();
    Console.WriteLine("Pedra Papel Tesoura Lagarto Spock!");
    Console.WriteLine("Opções");
    Console.WriteLine("1 - Pedra");
    Console.WriteLine("2 - Papel");
    Console.WriteLine("3 - Tesoura");
    Console.WriteLine("4 - Lagarto");
    Console.WriteLine("5 - Spock");

    var opcaoJogadorHum = EscolhaJogador(1);
    var opcaoJogadorDois = EscolhaJogador(2);
    var strategiaPrimeiroJogador = EstrategiaUsuarioFactory.Criar(opcaoJogadorHum);
    var jogo = new PedraPapelTesouraContext(strategiaPrimeiroJogador);

    Console.WriteLine(jogo.ObterResultado(opcaoJogadorDois));

    PosJogo();
}

static void PosJogo()
{
    Console.WriteLine("Digite 1 para reiniciar jogo ou 2 para finalizar.");
    int.TryParse(Console.ReadLine(), out int opcaoMenu);

    Console.Clear();

    switch (opcaoMenu)
    {
        case 1:
            Iniciar();
            break;
        case 2:
            Environment.Exit(0);
            break;
        default:
            PosJogo();
            break;
    }
}

static OpcaoJogador EscolhaJogador(int jogador)
{
    Console.WriteLine($"Jogador {jogador} digite uma opção, seguido de enter.");
    Enum.TryParse(Console.ReadLine(), out OpcaoJogador opcaoJogador);

    return opcaoJogador;
}