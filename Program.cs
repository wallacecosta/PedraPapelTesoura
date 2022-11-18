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

    Tipo opcaoJogadorHum, opcaoJogadorDois;
    opcaoJogadorHum = EscolhaJogador(out opcaoJogadorHum, 1);
    opcaoJogadorDois = EscolhaJogador(out opcaoJogadorDois, 2);

    Jogar(opcaoJogadorHum, opcaoJogadorDois);
}

static void DecisaoMenu(int entrada)
{
    var opcaoMenu = 0;

    Console.WriteLine($"Opção digitada {entrada} é invalida. Digite 1 para reiniciar ou 2 para finalizar");
    int.TryParse(Console.ReadLine(), out opcaoMenu);

    Console.Clear();

    if (opcaoMenu == 1)
    {
        Iniciar();
        return;
    }

    if (opcaoMenu == 2)
        Environment.Exit(0);

    DecisaoMenu(opcaoMenu);
}

static void PosJogo()
{
    var decisao = 0;
    Console.WriteLine("Deseja jogar novamente? \nDigite 1 para SIM ou 2 para NÃO");
    int.TryParse(Console.ReadLine(), out decisao);

    if (decisao == 1)
    {
        Iniciar();
        return;
    }

    if (decisao == 2)
        Environment.Exit(0);

    DecisaoMenu(decisao);
}

static Tipo EscolhaJogador(out Tipo opcaoJogador, int jogador)
{
    opcaoJogador = Tipo.Invalido;
    Console.WriteLine($"Jogador {jogador} digite uma opção, seguido de enter.");
    Enum.TryParse(Console.ReadLine(), out opcaoJogador);

    if (opcaoJogador == Tipo.Invalido)
        DecisaoMenu((int)opcaoJogador);

    return opcaoJogador;
}

static void Jogar(Tipo opcaoJogadorHum, Tipo opcaoJogadorDois)
{
    var pedraPapelTesoura = new PedraPapelTesoura(opcaoJogadorHum, opcaoJogadorDois);
    pedraPapelTesoura.Resultado();

    PosJogo();
}