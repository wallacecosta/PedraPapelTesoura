public class PedraPapelTesoura
{
    private const string JOGADOR_HUM_VENCEU = "Jogador 1 ganhou!";
    private const string JOGADOR_DOIS_VENCEU = "Jogador 2 ganhou!";

    private Tipo _opcaoJogadorHum;
    private Tipo _opcaoJogadorDois;

    public PedraPapelTesoura(Tipo opcaoJogadorHum, Tipo opcaoJogadorDois)
    {
        _opcaoJogadorHum = opcaoJogadorHum;
        _opcaoJogadorDois = opcaoJogadorDois;
    }

    public void Resultado()
    {
        if (_opcaoJogadorHum == _opcaoJogadorDois)
        {
            Console.WriteLine("Deu Empate");
            return;
        }

        switch (_opcaoJogadorHum)
        {
            case Tipo.Pedra:
                if (_opcaoJogadorDois == Tipo.Lagarto || _opcaoJogadorDois == Tipo.Tesoura)
                    Console.WriteLine(JOGADOR_HUM_VENCEU);
                else
                    Console.WriteLine(JOGADOR_DOIS_VENCEU);

                break;
            case Tipo.Papel:
                if (_opcaoJogadorDois == Tipo.Pedra || _opcaoJogadorDois == Tipo.Spock)
                    Console.WriteLine(JOGADOR_HUM_VENCEU);
                else
                    Console.WriteLine(JOGADOR_DOIS_VENCEU);

                break;
            case Tipo.Tesoura:
                if (_opcaoJogadorDois == Tipo.Papel || _opcaoJogadorDois == Tipo.Lagarto)
                    Console.WriteLine(JOGADOR_HUM_VENCEU);
                else
                    Console.WriteLine(JOGADOR_DOIS_VENCEU);

                break;
            case Tipo.Spock:
                if (_opcaoJogadorDois == Tipo.Tesoura || _opcaoJogadorDois == Tipo.Pedra)
                    Console.WriteLine(JOGADOR_HUM_VENCEU);
                else
                    Console.WriteLine(JOGADOR_DOIS_VENCEU);

                break;
            case Tipo.Lagarto:
                if (_opcaoJogadorDois == Tipo.Spock || _opcaoJogadorDois == Tipo.Papel)
                    Console.WriteLine(JOGADOR_HUM_VENCEU);
                else
                    Console.WriteLine(JOGADOR_DOIS_VENCEU);

                break;
            default:
                break;
        }
    }


}