public class Program
{
    //sobrecarga 1 para 2 numeros
    static public int Somar(int numero1, int numero2)
    {
        return numero1 + numero2;
    }
    //sobrecarga 2 para 3 numeros
    static public int Somar(int numero1, int numero2, int numero3)
    {
        return numero1 + numero2 + numero3;
    }
    //sobrecarga 3 para 4 numeros
    static public int Somar(int numero1, int numero2, int numero3, int numero4)
    {
        return numero1 + numero2 + numero3 + numero4;
    }

    //sobrecarga 5 para quantos numeros eu quiser.
    static public int Somar(params int[] numeros)
    {
        var resultado = 0;
        foreach (var numero in numeros)
        {
            resultado = resultado + numero;
            
        }

        return resultado;
    }

    static void Main(string[] args)
    {
        var resultado1 = Somar(1, 2, 3, 4, 5);
        var resultado2 = Program.Somar(1, 2);
        Console.ReadLine();
    }
}