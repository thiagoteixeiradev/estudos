//array
int[] numeros = new int[3];
numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 30;
//ou
int[] valores = { 10, 20, 30 };

//lista
List<string> nomes = new List<string>();
nomes.Add("Ana");
nomes.Add("Bruno");
nomes.Add("Carlos");
nomes.Remove("Ana");
Console.WriteLine(nomes[0]);

//inverter string
//LINQ
string texto = "Romario";
string invertida = new string(texto.Reverse().ToArray());
Console.WriteLine(invertida);
//ou usando um for
for (int i = texto.Length - 1; i >= 0; i--)
{
    invertida += texto[i];
}
//ou Array.Reverse
char[] texto2 = texto.ToCharArray();
Array.Reverse(texto2);
string invertida2 = new string(texto2);
Console.WriteLine(invertida2);