using UpDownCasting;

Circulo circulo = new Circulo();
Forma f = circulo; //upcast implicito

Circulo c = (Circulo)f; //DownCast

Console.WriteLine(c == f);
Console.WriteLine(c == circulo);

c.Desenhar();
c.PintarCirculo();
c.Desenhar();

//upcast converte um objeto especializado, para um mais geral, 
//downcast converte um objeto geral, para um mais especializado.
//deve ser explícito, pois pode falhar e lançar exceção.
