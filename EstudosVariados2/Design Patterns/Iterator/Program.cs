using System;
using System.Collections;

// Interface que define os métodos para iterar sobre a coleção
public interface IIterator
{
    object First();
    object Next();
    bool IsDone();
    object CurrentItem();
}

// Interface que define o método para criar o iterador
public interface IAggregate
{
    IIterator CreateIterator();
    int Count { get; }
    object this[int index] { get; set; }
}

// Classe concreta que implementa a coleção
public class ConcreteAggregate : IAggregate
{
    private ArrayList items = new ArrayList();

    public void AddItem(object item)
    {
        items.Add(item);
    }

    public IIterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    public int Count
    {
        get { return items.Count; }
    }

    public object this[int index]
    {
        get { return items[index]; }
        set { items.Insert(index, value); }
    }
}

// Classe concreta do iterador
public class ConcreteIterator : IIterator
{
    private ConcreteAggregate aggregate;
    private int current = 0;

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this.aggregate = aggregate;
    }

    public object First()
    {
        current = 0;
        return aggregate.Count > 0 ? aggregate[0] : null;
    }

    public object Next()
    {
        object resultado = null;
        current++;
        if (current < aggregate.Count)
        {
            resultado = aggregate[current];
        }
        return resultado;
    }

    public bool IsDone()
    {
        return current >= aggregate.Count;
    }

    public object CurrentItem()
    {
        if (current < aggregate.Count)
            return aggregate[current];
        return null;
    }
}

// Programa principal para testar o padrão Iterator
class Program
{
    static void Main(string[] args)
    {
        ConcreteAggregate aggregate = new ConcreteAggregate();
        aggregate.AddItem("Item 1");
        aggregate.AddItem("Item 2");
        aggregate.AddItem("Item 3");

        IIterator iterator = aggregate.CreateIterator();

        Console.WriteLine("Iterando sobre os itens:");
        for (object item = iterator.First(); !iterator.IsDone(); item = iterator.Next())
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }
}
