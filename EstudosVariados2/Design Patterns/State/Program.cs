//Interface
public interface IState
{
    void Handle(Context context);
}

//implementação dos estados

public class StateA : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Execução do estado A.");
        context.State = new StateB();
    }
}

public class StateB : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Execução do estado B.");
        context.State = new StateA();
    }
}

public class Context
{
    private IState _state;
    public Context(IState state)
    {
        State = state;
    }
    public IState State
    {
        get { return _state; }
        set
        {
            _state = value;
            Console.WriteLine($"Estado alterado para: {_state.GetType().Name}");
        }
    }
    public void Request()
    {
        _state.Handle(this);
    }
}

//Exemplo de uso

class Program
    {
    static void Main(string[] args)
    {
        Context context = new Context(new StateA());
        context.Request(); // Executa o estado A e muda para B
        context.Request(); // Executa o estado B e muda para A
        context.Request(); // Executa o estado A e muda para B

        Console.ReadKey();

    }
}