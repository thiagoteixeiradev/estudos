using Inversão_de_dependencia.Correto;

public class Conectando
{
    private IDatabaseConnection conexaoBanco;

    public Conectando(IDatabaseConnection _conexao)
    {
        this.conexaoBanco = _conexao;
    }

    //codigo para realizar as operações
}