//interface para o observer

public interface IObserver
{
    void Update(int value);
}

// define a classe concreta do observer

public class  ConcreteObserver: IObserver
{
    private string _observerName;

    public ConcreteObserver(string name)
    {
        _observerName = name;
    }

    public void Update(int value )
    {
        Console.WriteLine($"{_observerName} recebeu uma atualização: {value}");
    }
}

// define a interface do usuário

public interface ISubject
{
    void RegisterOberser(IObserver observer);
    void RemoveOberser(IObserver observer);
    void NotifyObservers(int value);
}

//agora a classe concreta do subject

public class ConcreteSubject : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    public void RegisterOberser(IObserver observer)
    {
        _observers.Add(observer);
    }
    public void RemoveOberser(IObserver observer)
    {
        _observers.Remove(observer);
    }
    public void NotifyObservers(int value)
    {
        foreach (var observer in _observers)
        {
            observer.Update(value);
        }
    }
    //método para alterar o estado do subject e notificar os observers
    public void ChangeState(int value)
    {
        Console.WriteLine($"O estado do Subject mudou para: {value}");
        NotifyObservers(value);
    }
}

class Program {
    static void Main(string[] args)
    {
        //cria o subject
        ConcreteSubject subject = new ConcreteSubject();
        //cria os observers
        ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
        ConcreteObserver observer2 = new ConcreteObserver("Observer 2");
        //registra os observers no subject
        subject.RegisterOberser(observer1);
        subject.RegisterOberser(observer2);

        subject.NotifyObservers(42);
        //remove um observer e altera o estado novamente
        subject.RemoveOberser(observer2);
        subject.NotifyObservers(84);

        Console.ReadKey();
    }
}