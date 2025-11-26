//Organizator

public interface IOriginator
{
    ConcreteMemento Salvar();
}

public class EditorTexto : IOriginator
{
    public string Texto;

    public EditorTexto(string texto)
    {
        Texto = texto;
    }

    public void Escrever( string novoTexto)
    {
        Texto += " " + novoTexto;
        Console.WriteLine($"Escrevendo: {Texto}");
        
    }

    public ConcreteMemento Salvar()
    {
        Console.WriteLine("Salvando estado. Texto Atual: " + Texto);
        return new ConcreteMemento(Texto);
    }

    public void Restaurar(IMemento memento)
    {
        if (memento is ConcreteMemento concreteMemento)
        {
            Texto = concreteMemento.GetText();
            Console.WriteLine("Estado restaurado. Texto Atual: " + Texto);
        }
        else
        {
            throw new ArgumentException("Memento inválido");
        }
    }

    public void ExibirTexto()
    {
        Console.WriteLine("Texto Atual: " + Texto);
    }
}

//Classe ConcreteMemento

public interface IMemento
{
    string GetText();
}

public class  ConcreteMemento : IMemento
{
    private readonly string texto;

    public ConcreteMemento(string texto)
    {
        this.texto = texto;
    }

    public string GetText()
    {
        return texto;
    }

}

//Classe Caretaker

public class Caretaker
{
    private List<ConcreteMemento> estadosSalvos = new();
    public void AdicionarMemento(ConcreteMemento memento)
    {
        estadosSalvos.Add(memento);
    }
    public IMemento GetMemento(int indice)
    {
        return estadosSalvos[indice];
    }

}

//Exemplo

class Program
{
    static void Main(string[] args)
    {
        EditorTexto editor = new EditorTexto("Texto Inicial");
        Caretaker caretaker = new Caretaker();
        editor.ExibirTexto();
        // Escrever e salvar estado
        editor.Escrever("Primeira frase.");
        caretaker.AdicionarMemento(editor.Salvar());
        editor.Escrever("Segunda frase.");
        caretaker.AdicionarMemento(editor.Salvar());
        editor.Escrever("Terceira frase.");
        caretaker.AdicionarMemento(editor.Salvar());
        editor.ExibirTexto();
        // Restaurar para o estado anterior
        editor.Restaurar(caretaker.GetMemento(1));
        editor.ExibirTexto();
        // Restaurar para o estado inicial
        editor.Restaurar(caretaker.GetMemento(0));
        editor.ExibirTexto();
    }
}