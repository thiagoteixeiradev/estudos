using System;
using System.Collections.Generic;

// Interface Mediator
public interface IChatRoom
{
    void Register(User user);
    void Send(string message, User user);
}

// Concrete Mediator
public class ChatRoom : IChatRoom
{
    private List<User> users = new List<User>();

    public void Register(User user)
    {
        if (!users.Contains(user))
        {
            users.Add(user);
            user.SetChatRoom(this);
        }
    }

    public void Send(string message, User user)
    {
        foreach (var u in users)
        {
            if (u != user)
            {
                u.Receive(message);
            }
        }
    }
}

// Classe Colleague (abstrata)
public abstract class User
{
    protected IChatRoom chatRoom;

    public User(IChatRoom chatRoom)
    {
        this.chatRoom = chatRoom;
    }

    public void SetChatRoom(IChatRoom chatRoom)
    {
        this.chatRoom = chatRoom;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message);
}

// Classe ConcreteColleague
public class ChatUser : User
{
    public string Name { get; set; }

    public ChatUser(string name, IChatRoom chatRoom) : base(chatRoom)
    {
        this.Name = name;
    }

    public override void Send(string message)
    {
        Console.WriteLine($"{Name} fala: {message}");
        chatRoom.Send(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"{Name} recebe: {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {

        //Cria a sala de chat
        IChatRoom chatRoom = new ChatRoom();

        //Cria os usuarios
        User user1 = new ChatUser("Alice", chatRoom);
        User user2 = new ChatUser("Bob", chatRoom);
        User user3 = new ChatUser("Charlie", chatRoom);
        User user4 = new ChatUser("Romario", chatRoom);

        //Registra os usuarios na sala de chat
        chatRoom.Register(user1);
        chatRoom.Register(user2);
        chatRoom.Register(user3);
        chatRoom.Register(user4);

        //Usuarios enviam mensagens
        user1.Send("Olá, pessoal!");
        user2.Send("Oi, Alice!");
        user3.Send("E aí, galera!");
        user3.Send("Oi, eu sou Romario!");

        Console.ReadKey();
    }
}
