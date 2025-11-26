using UpDownCasting;

Forma f = new Forma();
//o operador as é usado para executar uma conversão entre tipos de referência compatíveis ou tipos anuláveis


Circulo c = f as Circulo; // c sera null

if (c != null)
{
    c.PintarCirculo();
}
else
{
    Console.WriteLine("O resultado foi nulo");
}

//já o operador is, verifica se um objeto é compatível com o tipo especificado ou não, retorna true se for.
//caso seja falsou ou nulo, retorna false.

Circulo c2 = new Circulo();
Forma f2 = c2; //upcast implícito

if (f2 is Circulo) //verificar o downcast
{
    ((Circulo)f2).PintarCirculo();
}
else
{
    Console.WriteLine("Downcast inválido");
}