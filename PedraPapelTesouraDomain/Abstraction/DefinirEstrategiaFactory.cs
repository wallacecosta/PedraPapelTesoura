using PedraPapelTesoura.Domain;

namespace PedraPapelTesouraDomain.Abstraction;

public static class EstrategiaUsuarioFactory
{
    public static IPedraPapelTesouraStrategy Criar(OpcaoJogador opcaoJogadorHum)
    {
        switch (opcaoJogadorHum)
        {
            case OpcaoJogador.Pedra:
                return new PrimeiroJogadorEscolhePedraStrategy();
            case OpcaoJogador.Papel:
                return new PrimeiroJogadorEscolhePapelStrategy();
            case OpcaoJogador.Tesoura:
                return new PrimeiroJogadorEscolheTesouraStrategy();
            case OpcaoJogador.Spock:
                return new PrimeiroJogadorEscolheSpockStrategy();
            case OpcaoJogador.Lagarto:
                return new PrimeiroJogadorEscolheLagartoStrategy();
            default:
                return new PrimeiroJogadorEscolheInvalidoStrategy();
        }
    }
}
