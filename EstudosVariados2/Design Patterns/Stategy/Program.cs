//interface para estrategia

public interface IStrategy
{
    void Execute();
}

//implementacion de estrategias

public class StategyA : IStrategy
{
       public void Execute()
    {
        Console.WriteLine("Estrategia A executada");
    }
}

public class StategyB : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Estrategia A executada");
    }
}

public class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        _strategy.Execute();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Context context = new Context(new StategyA());
        context.ExecuteStrategy();

        context.SetStrategy(new StategyB());
        context.ExecuteStrategy();
    }
}