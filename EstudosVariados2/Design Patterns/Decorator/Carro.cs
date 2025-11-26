namespace Decorator;

public sealed class Carro : ICarro
{
    public string RetornarCarro()
    {
        var carro = "Este é um carro";
        return carro;
    }
}