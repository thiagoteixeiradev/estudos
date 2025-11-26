using Banco;
using System.Security.Cryptography.X509Certificates;

public class ContaPoupanca : Conta
{
    public int JurosMensais { get; set; }


    //posso usar override para substituir um método, ou new para ocultar o antigo
    //Posso usar o base(parametro) para acessar os parametros da classe pai.

    public void GetSaldo2()
    {
        Console.WriteLine("(CS) Seu saldo é: " + Saldo);
        base.Saldo = 100;
        base.Numero = 001;

    }

    public static void Main(string[] args)
    {
        var Conta = new Conta();


    }
}