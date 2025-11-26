//elemento visitável

public class Pessoa
{
    public string nome { get; set; }
    public int Idade { get; set; }

    public virtual void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

//interface visitante
public interface IVisitor
{
    void Visit(Pessoa pessoa);
}

//Implementação do visitante

public class PessoaVisitor : IVisitor
{
    public void Visit(Pessoa pessoa)
    {
        if(pessoa.Idade >= 18)
        {
            Console.WriteLine($"{pessoa.nome} é maior de idade.");
        }
        else
        {
            Console.WriteLine($"{pessoa.nome} é menor de idade.");
        }
    }
}

//implementação no cliente

class Program
{
    static void Main(string[] args)
    {
        var pessoa1 = new Pessoa { nome = "Romário", Idade = 20 };
        var pessoa2 = new Pessoa { nome = "Sabrina", Idade = 16 };

        var visitor = new PessoaVisitor();

        pessoa1.Accept(visitor);
        pessoa2 .Accept(visitor);
    }
}