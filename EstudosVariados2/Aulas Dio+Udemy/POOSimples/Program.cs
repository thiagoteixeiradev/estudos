using POOSimples;


//instânciando um objeto.
Pessoa romario = new();
romario.nome = "Romário";
romario.genero = "Masculino";
romario.idade = 31;
romario.Identificar();

Pessoa p1 = new Pessoa("Amana", 25, "feminino");
p1.Identificar();

Pessoa p2 = new Pessoa("Caio");
p2.Identificar();

Console.WriteLine("Agora o nosso construct");

PessoaConstruct p3 = new PessoaConstruct("Romário Construido");
p3.Genero = "Masculino Construido";
p3.Idade = 20;

Console.WriteLine(p3.Nome);
Console.WriteLine(p3.Idade);

Console.WriteLine("Soma = " + StaticCalcular.Calcular(5, 3));